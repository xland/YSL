using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 其他类型的物资模版项
    /// </summary>
    public class mm_other_template_item
    {
        /// <summary>
        /// 其他类型的物资模版项ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 模版项名称
        /// </summary>
        public string item_name
        {
            get;
            set;
        }
        /// <summary>
        /// 模版项类型，0整型，1字符串，2小数
        /// </summary>
        public int type
        {
            get;
            set;
        }
        /// <summary>
        /// 模版ID
        /// </summary>
        public string mm_template_id
        {
            get;
            set;
        }
        /// <summary>
        /// 模版项排序
        /// </summary>
        public int order_num
        {
            get;
            set;
        }
    }
}
