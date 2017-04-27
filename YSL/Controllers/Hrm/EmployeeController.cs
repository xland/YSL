using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using Microsoft.EntityFrameworkCore;
using YSL.Common;
using Newtonsoft.Json.Linq;

namespace YSL.Controllers.Hrm
{
    /// <summary>
    /// 员工控制器
    /// </summary>
    public class EmployeeController : Controller
    {
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public JsonResult GetEmployeeByPage([FromBody]JObject form)
        {
            var page = form["pager"].ToObject<PageDataRequestModel>();
            var searchTxt = form["searchTxt"] == null ? "" : form["searchTxt"].ToString();
            List<hrm_employee> data;
            int rowCount = 0;
            var db = new YSLContext();
            try
            {
                var query = db.hrm_employee
                    .Where(m => m.employee_name.Contains(searchTxt))
                    .OrderByDescending(m => m.add_time);
                rowCount = query.Count();
                data = query.Skip(page.page_index * page.page_size)
                    .Take(page.page_size).ToList();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("获取所有系统权限异常！");
            }
            finally
            {
                db.Dispose();
            }
            var result = ResultToJson.ToSuccess(rowCount, data);
            return result;
        }
        /// <summary>
        /// 新增或修改员工信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveEmployee([FromBody]hrm_employee employee)
        {
            //todo:根据身份证号，获取生日；客户端校验身份证号是否合法；
            var addFlag = false;
            if (string.IsNullOrEmpty(employee.id))
            {
                employee.id = Guid.NewGuid().ToString("N");
                employee.add_time = DateTime.Now;
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(employee).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                return ResultToJson.ToError("新增或修改员工信息失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除一个员工；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelEmployee([FromBody] hrm_employee target)
        {
            var db = new YSLContext();
            try
            {
                db.hrm_employee.Attach(target);
                db.hrm_employee.Remove(target);
                db.SaveChanges();
            }
            catch (Exception ex)
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
        /// 根据员工ID，获取员工信息；
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetEmployeeById([FromBody] hrm_employee target)
        {
            var db = new YSLContext();
            hrm_employee result;
            try
            {
                result = db.hrm_employee.Where(m => m.id == target.id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("删除账户失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess(result);
        }

    }
}