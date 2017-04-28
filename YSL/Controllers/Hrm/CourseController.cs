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
    /// 课程控制器
    /// </summary>
    public class CourseController : Controller
    {
        /// <summary>
        /// 获取课程列表
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public JsonResult GetCourseByPage([FromBody]JObject form)
        {
            var page = form["pager"].ToObject<PageDataRequestModel>();
            var searchTxt = form["searchTxt"] == null ? "" : form["searchTxt"].ToString();
            List<hrm_course> data;
            int rowCount = 0;
            var db = new YSLContext();
            try
            {
                var query = db.hrm_course
                    .Where(m => m.course_name.Contains(searchTxt))
                    .OrderByDescending(m => m.level);
                rowCount = query.Count();
                data = query.Skip(page.page_index * page.page_size)
                    .Take(page.page_size).ToList();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("获取课程列表异常！");
            }
            finally
            {
                db.Dispose();
            }
            var result = ResultToJson.ToSuccess(rowCount, data);
            return result;
        }
        /// <summary>
        /// 新增或修改课程项目
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public IActionResult SaveCourse([FromBody]hrm_course course)
        {
            var addFlag = false;
            if (string.IsNullOrEmpty(course.id))
            {
                course.id = Guid.NewGuid().ToString("N");
                addFlag = true;
            }
            var db = new YSLContext();
            try
            {
                db.Entry(course).State = addFlag ? EntityState.Added : EntityState.Modified;
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                return ResultToJson.ToError("新增或修改课程项目失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除一个课程；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult DelCourse([FromBody]hrm_course target)
        {
            var db = new YSLContext();
            try
            {
                db.hrm_course.Attach(target);
                db.hrm_course.Remove(target);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("删除课程失败！");
            }
            finally
            {
                db.Dispose();
            }
            return ResultToJson.ToSuccess();
        }
    }
}