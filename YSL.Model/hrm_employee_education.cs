using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 员工教育经历
    /// </summary>
    public class hrm_employee_education
    {
        /// <summary>
        /// 教育经历ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime start_time
        {
            get;
            set;
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime end_time
        {
            get;
            set;
        }
        /// <summary>
        /// 学校名称
        /// </summary>
        public string school_name
        {
            get;
            set;
        }
        /// <summary>
        /// 学位
        /// </summary>
        public string degree
        {
            get;
            set;
        }
    }
}
