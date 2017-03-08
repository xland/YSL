using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 员工教育经历过程中所获取的证书
    /// </summary>
    public class hrm_employee_education_certificate
    {
        /// <summary>
        /// 教育经历证书ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 证书编号
        /// </summary>
        public int certificate_num
        {
            get;
            set;
        }
        /// <summary>
        /// 证书名称
        /// </summary>
        public string certificate_name
        {
            get;
            set;
        }
        /// <summary>
        /// 教育经历ID
        /// </summary>
        public string education_id
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
