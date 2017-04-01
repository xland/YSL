using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using YSL.Common;
using Microsoft.EntityFrameworkCore;

namespace YSL.Controllers.Sys
{
    public class AccountController : Controller
    {
        /// <summary>
        /// 获取帐号信息
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public JsonResult GetAccountByPage([FromBody]JObject form)
        {
            var page = form["pager"].ToObject<PageDataRequestModel>();
            var searchTxt = form["searchTxt"]==null?"":form["searchTxt"].ToString();
            List<sys_account> data;
            int rowCount = 0;
            var db = new YSLContext();
            try
            {
                var query = db.sys_account
                    .Where(m => m.account_name.Contains(searchTxt))
                    .OrderByDescending(m => m.add_time);
                rowCount = query.Count();
                query.Skip(page.page_index * page.page_size)
                    .Take(page.page_size)
                    .Select(m => new sys_account
                    {
                        id = m.id,
                        account_name = m.account_name,
                        add_time = m.add_time,
                        employee_id = m.employee_id
                    });
                data = query.ToList();
            }
            catch
            {
                return ResultToJson.ToError("获取所有系统权限异常！");
            }
            finally
            {
                db.Dispose();
            }
            var result = ResultToJson.ToSuccess(rowCount,data);
            return result;
        }
        /// <summary>
        /// 系统登录
        /// </summary>
        /// <returns></returns>
        public JsonResult Login(sys_account account)
        {
            account.pass_word = Encrypt.getMD5Code(account.pass_word);
            sys_account cur_user;
            List<string> funcIds;
            var db = new YSLContext();
            try
            {

                cur_user = db.sys_account.Where(m => m.account_name == account.account_name && m.pass_word == account.pass_word).First();
                var roleIds = db.sys_account_role.Where(m => m.account_id == cur_user.id).Select(m => m.role_id);
                funcIds = db.sys_role_func.Where(m => roleIds.Contains(m.role_id)).Select(m => m.func_id).ToList();
            }
            catch
            {
                return ResultToJson.ToError("用户名或密码错误！");
            }
            finally
            {
                db.Dispose();
            }
            HttpContext.Session.Set("CurUser", cur_user);
            HttpContext.Session.Set("CurUserFunc", funcIds);
            var obj = new { FuncIds = funcIds, Account = cur_user };
            return ResultToJson.ToSuccess(obj);
        }
        /// <summary>
        /// 新增或修改账户
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult SaveAccount([FromBody]sys_account account)
        {
            account.pass_word = Encrypt.getMD5Code(account.pass_word);
            var addFlag = false;
            if (string.IsNullOrEmpty(account.id))
            {
                account.id = Guid.NewGuid().ToString("N");
                account.add_time = DateTime.Now;
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(account).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("新增或修改账户失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 查找系统中是否已存在相同的账户
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public JsonResult CheckAccountName([FromBody] sys_account target)
        {
            var result = true;
            var db = new YSLContext();
            try
            {
                var count = db.sys_account.Where(m => m.account_name == target.account_name).Count();
                result = count > 0;
            }
            catch
            {
                return ResultToJson.ToError("查找系统中是否已存在相同的账户失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess(result);
        }
        /// <summary>
        /// 删除账户；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DelAccount([FromBody]sys_account target)
        {
            //todo:需要逻辑删除
            var db = new YSLContext();
            try
            {
                db.sys_account.Attach(target);
                db.sys_account.Remove(target);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("删除账户失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 为一个账户更新角色（先都删掉，再新增）
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="funcId"></param>
        /// <returns></returns>
        public JsonResult UpdateAccountRole([FromBody] JObject form)
        {
            var db = new YSLContext();
            List<sys_account_role> ar = form["account_role"].ToObject<List<sys_account_role>>();
            ar.ForEach(m => { m.id = Guid.NewGuid().ToString("N"); });
            try
            {
                db.Database.ExecuteSqlCommand("delete from sys_account_role where account_id = {0}", form["account_id"].ToString());
                db.sys_account_role.AddRange(ar);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                return ResultToJson.ToError("为一个账户删除一个角色失败");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 获取一个账户所拥有的角色
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult GetAccountRole([FromBody]sys_account obj)
        {
            var db = new YSLContext();
            List<sys_role> roles;
            try
            {
                var linq = from v in db.sys_role
                join r in db.sys_account_role on v.id equals r.role_id
                where r.account_id == obj.id
                select v;
                roles = linq.ToList();
            }
            catch
            {
                return ResultToJson.ToError("获取一个账户所拥有的角色失败");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess(roles);
        }
    }
}