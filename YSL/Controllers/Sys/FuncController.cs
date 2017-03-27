using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSL.Model;
using YSL.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace YSL.Controllers.Sys
{
    public class FuncController : Controller
    {
        private IMemoryCache cache;
        public FuncController(IMemoryCache memoryCache)
        {
            this.cache = memoryCache;
        }
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
        /// 生成树形菜单的递归函数
        /// </summary>
        /// <param name="curNode"></param>
        /// <param name="allNode"></param>
        private void InitSubNode(sys_func curNode,List<sys_func> allNode)
        {
            foreach(var n in allNode)
            {
                if(n.pid == curNode.id)
                {
                    if(curNode.children == null)
                    {
                        curNode.children = new List<sys_func>();
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
        public IActionResult GetAllFuncTree()
        {
            List<sys_func> tree;
            if (this.cache.TryGetValue<List<sys_func>>("Func_Tree", out tree))
            {
                return ResultToJson.ToSuccess(tree);
            }
            List<sys_func> data;
            var db = new YSLContext();
            try
            {
                data = db.sys_func.ToList();
            }
            catch (Exception ex)
            {
                return ResultToJson.ToError("获取所有系统权限异常！");
            }
            finally
            {
                db.Dispose();
            }
            tree = new List<sys_func>();
            foreach (var item in data)
            {
                if (string.IsNullOrEmpty(item.pid))
                {
                    tree.Add(item);
                    InitSubNode(item, data);
                }
            }
            this.cache.Set<List<sys_func>>("Func_Tree", tree);
            var result = ResultToJson.ToSuccess(tree);
            return result;
        }
        /// <summary>
        /// 新增或修改系统权限
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsonResult SaveFunc([FromBody]sys_func obj)
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
            this.cache.Remove("Func_Tree");
            return ResultToJson.ToSuccess();
        }
        /// <summary>
        /// 删除系统权限；物理删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult DelFunc([FromBody]sys_func target)
        {
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
            this.cache.Remove("Func_Tree");
            return ResultToJson.ToSuccess();
        }
    }
}