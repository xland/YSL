using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 部门KPI考核模版
    /// </summary>
    public class hrm_department_kpi_template
    {
        /// <summary>
        /// 部门KPI考核模版ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项父ID
        /// </summary>
        public string pid
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项名称
        /// </summary>
        public string item_name
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项基准分
        /// </summary>
        public string standard_score
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项类型 0按月，1按周，2按年
        /// </summary>
        public string item_type
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项是否已删除
        /// </summary>
        public int is_delete
        {
            get;
            set;
        }
        /// <summary>
        /// 部门ID
        /// </summary>
        public string department_id
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项排序
        /// </summary>
        public string order_num
        {
            get;
            set;
        }
    }
}
