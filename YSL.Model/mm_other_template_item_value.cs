using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 其他物资模版项值
    /// </summary>
    public class mm_other_template_item_value
    {
        /// <summary>
        /// 其他物资模版项值的ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 其他物资模版项值
        /// </summary>
        public string item_value
        {
            get;
            set;
        }
        /// <summary>
        /// 其他物资模版项ID
        /// </summary>
        public string template_item_id
        {
            get;
            set;
        }
        /// <summary>
        /// 其他物资模版ID
        /// </summary>
        public string template_id
        {
            get;
            set;
        }
        /// <summary>
        /// 增加用户ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 物资基类ID
        /// </summary>
        public string base_id
        {
            get;
            set;
        }
    }
}
