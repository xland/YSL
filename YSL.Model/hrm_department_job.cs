using System.ComponentModel.DataAnnotations;
using System;

namespace YSL.Model
{
    /// <summary>
    /// 部门招聘岗位
    /// </summary>
    public class hrm_department_job
    {
        /// <summary>
        /// 部门招聘岗位ID
        /// </summary>
        [Key]
        public string id
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
        /// 岗位类型
        /// </summary>
        public string job_type_id
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位招聘开始时间；不填写为马上开始
        /// </summary>
        public DateTime start_time
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位招聘结束时间；不填写为长期招聘
        /// </summary>
        public DateTime end_time
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位薪资区间范围开始
        /// </summary>
        public int money_start
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位薪资区间范围截止
        /// </summary>
        public int money_end
        {
            get;
            set;
        }
        /// <summary>
        /// 岗位所属部门ID
        /// </summary>
        public string department_id
        {
            get;
            set;
        }
        /// <summary>
        /// 最少招聘人数
        /// </summary>
        public int job_num_start
        {
            get;
            set;
        }
        /// <summary>
        /// 最多招聘人数
        /// </summary>
        public int job_num_end
        {
            get;
            set;
        }
    }
}
