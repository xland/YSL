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
    /// 培训控制器
    /// </summary>
    public class TrainController : Controller
    {
        /// <summary>
        /// 新增或修改培训项目
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveEmployee(hrm_train train)
        {
            var addFlag = false;
            if (string.IsNullOrEmpty(train.id))
            {
                train.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(train).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return ResultToJson.ToError("新增或修改培训项目失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除一个培训项目；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelAccount(string id)
        {
            var target = new hrm_train() { id = id };
            var db = new YSLContext();
            try
            {
                db.hrm_train.Attach(target);
                db.hrm_train.Remove(target);
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
    }
}