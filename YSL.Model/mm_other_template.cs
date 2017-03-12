using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 其他物资模版
    /// </summary>
    public class mm_other_template
    {
        /// <summary>
        /// 其他物资模版ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 模版名称
        /// </summary>
        public string template_name
        {
            get;
            set;
        }
        /// <summary>
        /// 模版描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 物资基类ID
        /// </summary>
        public string mm_base_id
        {
            get;
            set;
        }
    }
}
