using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 考核项考核记录
    /// </summary>
    public class hrm_employee_kpi
    {
        /// <summary>
        /// 考核项考核记录ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 增加者ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 考核项得分
        /// </summary>
        public int score
        {
            get;
            set;
        }
        /// <summary>
        /// 模版ID
        /// </summary>
        public string kpi_template_id
        {
            get;
            set;
        }
        /// <summary>
        /// 批次编号
        /// </summary>
        public int batch_num
        {
            get;
            set;
        }
    }
}
