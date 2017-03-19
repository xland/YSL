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
    public class FuncController : Controller
    {
        /// <summary>
        /// 获取所有系统权限
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllFunc()
        {
            List<sys_func> data;
            var db = new YSLContext();
            try
            {
                data = db.sys_func.ToList();
            }
            catch(Exception ex)
            {
                return ResultToJson.ToError("获取所有系统权限异常！");
            }
            finally
            {
                db.Dispose();
            }
            var result = ResultToJson.ToSuccess(data);
            return result;
        }
        /// <summary>
        /// 新增或修改系统权限
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult SaveFunc(sys_func obj)
        {
            var db = new YSLContext();
            var addFlag = false;
            if (string.IsNullOrEmpty(obj.id))
            {
                obj.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            try
            {
                db.Entry(obj).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("新增或修改系统权限失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除系统权限；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DelFunc(string id)
        {
            var target = new sys_func() { id = id };
            var db = new YSLContext();
            try
            {
                db.sys_func.Attach(target);
                db.sys_func.Remove(target);
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("删除系统权限失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
    }
}