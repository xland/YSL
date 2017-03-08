using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 面试
    /// </summary>
    public class hrm_interview
    {
        /// <summary>
        /// 面试ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 面试开始时间
        /// </summary>
        public DateTime start_time
        {
            get;
            set;
        }
        /// <summary>
        /// 面试官ID
        /// </summary>
        public string interviewer_id
        {
            get;
            set;
        }
        /// <summary>
        /// 面试备注
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 上次面试的ID
        /// </summary>
        public string pid
        {
            get;
            set;
        }
        /// <summary>
        /// 招聘岗位ID
        /// </summary>
        public string target_job_id
        {
            get;
            set;
        }
        /// <summary>
        /// 面试者姓名
        /// </summary>
        public string applicant
        {
            get;
            set;
        }
        /// <summary>
        /// 面试者电话
        /// </summary>
        public string applicant_phone
        {
            get;
            set;
        }
        /// <summary>
        /// 期望薪资开始
        /// </summary>
        public string money_start
        {
            get;
            set;
        }
        /// <summary>
        /// 期望薪资结束
        /// </summary>
        public string money_end
        {
            get;
            set;
        }
        /// <summary>
        /// 本次面试是否结束：0预约中；1已结束；2已改期
        /// </summary>
        public int is_finish
        {
            get;
            set;
        }
        /// <summary>
        /// 本次面试是否通过：0没通过；1通过；2差强人意
        /// </summary>
        public int is_access
        {
            get;
            set;
        }
        /// <summary>
        /// 是否需要再次面试：0不需要，面试终结了，如果是面试通过，那就要发offer了；1需要；
        /// </summary>
        public int once_more
        {
            get;
            set;
        }
        /// <summary>
        /// 简历下载路径
        /// </summary>
        public string resume_url
        {
            get;
            set;
        }
    }
}
