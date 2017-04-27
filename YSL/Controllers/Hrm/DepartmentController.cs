using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using Microsoft.EntityFrameworkCore;
using YSL.Common;
using Microsoft.Extensions.Caching.Memory;

namespace YSL.Controllers.Hrm
{
    /// <summary>
    /// 部门控制器
    /// </summary>
    public class DepartmentController : Controller
    {
        private IMemoryCache cache;
        public DepartmentController(IMemoryCache memoryCache)
        {
            this.cache = memoryCache;
        }
        /// <summary>
        /// 生成部门的层级结构的递归函数
        /// </summary>
        /// <param name="curNode"></param>
        /// <param name="allNode"></param>
        private void InitSubNode(hrm_department curNode, List<hrm_department> allNode)
        {
            foreach (var n in allNode)
            {
                if (n.pid == curNode.id)
                {
                    if (curNode.children == null)
                    {
                        curNode.children = new List<hrm_department>();
                    }
                    curNode.children.Add(n);
                    InitSubNode(n, allNode);//todo:这样写递归，会是一个坑；
                }
            }
        }
        /// <summary>
        /// 获取所有系统权限
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllDepartmentTree()
        {
            List<hrm_department> tree;
            if (this.cache.TryGetValue("Department_Tree", out tree))
            {
                return ResultToJson.ToSuccess(tree);
            }
            List<hrm_department> data;
            var db = new YSLContext();
            try
            {
                data = db.hrm_department.OrderBy(m => m.order_num).ToList();
            }
            catch(Exception ex)
            {
                return ResultToJson.ToError("获取所有系统权限异常！");
            }
            finally
            {
                db.Dispose();
            }
            tree = new List<hrm_department>();
            foreach (var item in data)
            {
                if (string.IsNullOrEmpty(item.pid))
                {
                    tree.Add(item);
                    InitSubNode(item, data);
                }
            }
            cache.Set("Department_Tree", tree);
            var result = ResultToJson.ToSuccess(tree);
            return result;
        }
        /// <summary>
        /// 新增或修改部门信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveDepartment([FromBody]hrm_department obj)
        {
            var addFlag = false;
            if (string.IsNullOrEmpty(obj.id))
            {
                obj.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(obj).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("新增或修改部门信息失败！");
            }
            finally
            {
                db.Dispose();
            }
            cache.Remove("Department_Tree");
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除一个部门；物理删除；不会执行关联删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelDepartment([FromBody] hrm_department target)
        {
            var db = new YSLContext();
            try
            {
                db.hrm_department.Attach(target);
                db.hrm_department.Remove(target);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("删除部门失败！");
            }
            finally
            {
                db.Dispose();
            }
            cache.Remove("Department_Tree");
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 根据部门ID获取一个部门的所有员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GetEmployeeByDepartmentId([FromBody]hrm_department target)
        {
            var db = new YSLContext();
            List<hrm_employee> result;
            try
            {
                var ids = db.hrm_department_employee.Where(m => m.department_id == target.id).Select(m => m.employee_id);
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