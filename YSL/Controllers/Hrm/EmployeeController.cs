using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using Microsoft.EntityFrameworkCore;
using YSL.Common;

namespace YSL.Controllers.Hrm
{
    /// <summary>
    /// 员工控制器
    /// </summary>
    [Route("Hrm/[controller]")]
    public class EmployeeController : Controller
    {
        /// <summary>
        /// 新增或修改员工信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveEmployee(hrm_employee employee)
        {
            //todo:根据身份证号，获取生日；客户端校验身份证号是否合法；
            var addFlag = false;
            if (string.IsNullOrEmpty(employee.id))
            {
                employee.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(employee).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
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
        public IActionResult DelAccount(string id)
        {
            var target = new hrm_employee() { id = id };
            var db = new YSLContext();
            try
            {
                db.hrm_employee.Attach(target);
                db.hrm_employee.Remove(target);
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
        /// 根据员工ID，获取员工信息；
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetEmployeeById(string id)
        {
            var db = new YSLContext();
            hrm_employee result;
            try
            {
                result = db.hrm_employee.Where(m => m.id == id).FirstOrDefault();
            }
            catch
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