using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 员工工作经历
    /// </summary>
    public class hrm_employee_work_experience
    {
        /// <summary>
        /// 工作经历ID
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
        /// 公司名称
        /// </summary>
        public string company_name
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string job_name
        {
            get;
            set;
        }
        /// <summary>
        /// 证明人
        /// </summary>
        public string certifier
        {
            get;
            set;
        }
        /// <summary>
        /// 证明人电话
        /// </summary>
        public string certifier_phone
        {
            get;
            set;
        }
        /// <summary>
        /// 员工ID
        /// </summary>
        public string employee_id
        {
            get;
            set;
        }
    }
}
