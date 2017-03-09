using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace YSL.Common
{
    public static class ResultToJson
    {
        /// <summary>
        /// 创建错误的JsonResult
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="code">默认值-1；500服务器内部错误；401未授权；501尚未实施；405方法已禁用；</param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static JsonResult ToError(string msg="系统异常", int code = -1,object data=null)
        {
            var obj = new { Msg = msg, Code = code, Data = data };
            return new JsonResult(obj);
        }
        /// <summary>
        /// 创建正常的JsonResult
        /// </summary>
        /// <param name="data"></param>
        /// <param name="msg"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static JsonResult ToSuccess(object data = null,string msg = "", int code = 0)
        {
            var obj = new { Msg = msg, Code = code, Data = data };
            return new JsonResult(obj);
        }
    }
}
