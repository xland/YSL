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
    public class DepartmentController : Controller
    {
        /// <summary>
        /// 新增或修改部门信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveDepartment(hrm_department obj)
        {
            var addFlag = false;
            if (string.IsNullOrEmpty(obj.id))
            {
                obj.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            var db = YSLContextFactory.Create();
            try
            {
                db.Entry(obj).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("新增或修改部门信息失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除一个部门；物理删除；不会执行关联删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelDepartment(string id)
        {
            var target = new hrm_department() { id = id };
            var db = YSLContextFactory.Create();
            try
            {
                db.hrm_department.Attach(target);
                db.hrm_department.Remove(target);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("删除部门失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 根据部门ID获取一个部门的所有员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetEmployeeByDepartmentId(string id)
        {
            var db = YSLContextFactory.Create();
            List<hrm_employee> result;
            try
            {
                var ids = db.hrm_department_employee.Where(m => m.department_id == id).Select(m => m.employee_id);
                var es = db.hrm_employee.Where(m => ids.Contains(m.id)).ToList();
                result = es;
            }
            catch
            {
                return ResultToJson.ToError("根据部门ID获取一个部门的所有员工失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess(result);
        }
    }
}