using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using YSL.Common;
using Microsoft.EntityFrameworkCore;

namespace YSL.Controllers.Sys
{
    public class RoleController : Controller
    {
        /// <summary>
        /// 获取系统所有角色
        /// </summary>
        /// <returns></returns>
        public JsonResult GetAllRole()
        {
            List<sys_role> roles;
            var db = new YSLContext();
            try
            {
                roles = db.sys_role.OrderBy(m=>m.order_num).ToList();
            }
            catch
            {
                return ResultToJson.ToError("获取系统所有角色错误！");
            }
            finally
            {
                db.Dispose();
            }
            var result = ResultToJson.ToSuccess(roles);
            return result;
        }
        /// <summary>
        /// 为一个角色增加一个权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="funcId"></param>
        /// <returns></returns>
        public JsonResult AddRoleFunc([FromBody]sys_role_func obj)
        {
            obj.id = Guid.NewGuid().ToString("N");
            var db = new YSLContext();
            try
            {
                db.sys_role_func.Add(obj);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("为一个角色增加一个权限失败");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 获取一个角色的所有权限
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult GetRoleFunc([FromBody]sys_role obj)
        {
            var db = new YSLContext();
            List<sys_func> roles;
            try
            {
                var linq = from v in db.sys_func
                           join r in db.sys_role_func on v.id equals r.func_id
                           where r.role_id == obj.id
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
        /// <summary>
        /// 为一个角色删除一个权限，物理删除
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="funcId"></param>
        /// <returns></returns>
        public JsonResult DelRoleFunc([FromBody]sys_role_func obj)
        {
            var db = new YSLContext();
            try
            {
                db.sys_role_func.Attach(obj);
                db.sys_role_func.Remove(obj);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("为一个角色删除一个权限失败");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 新增或修改角色
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult SaveRole([FromBody]sys_role role)
        {
            var db = new YSLContext();
            var addFlag = false;
            if (string.IsNullOrEmpty(role.id))
            {
                role.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            try
            {
                db.Entry(role).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("新增或修改角色失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 查找系统中是否已存在相同名称的角色
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public JsonResult CheckRoleName([FromBody] sys_role target)
        {
            var result = true;
            var db = new YSLContext();
            try
            {
                var count = db.sys_role.Where(m => m.role_name == target.role_name).Count();
                result = count > 0;
            }
            catch
            {
                return ResultToJson.ToError("查找系统中是否已存在相同的角色失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess(result);
        }
        /// <summary>
        /// 删除角色；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DelRole([FromBody] sys_role target)
        {
            var db = new YSLContext();
            try
            {
                db.sys_role.Attach(target);
                db.sys_role.Remove(target);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("删除角色失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
    }
}