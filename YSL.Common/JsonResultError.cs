using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Common
{
    public class JsonResultError
    {
        /// <summary>
        /// 500服务器内部错误；401未授权；501尚未实施；405方法已禁用；
        /// </summary>
        public int Code
        {
            get;
            set;
        }
        public string Msg
        {
            get;
            set;
        }
        public string Data
        {
            get;
            set;
        }
    }
}
