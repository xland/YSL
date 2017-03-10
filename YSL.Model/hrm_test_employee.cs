using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 员工考试
    /// </summary>
    public class hrm_test_employee
    {
        /// <summary>
        /// 员工考试ID
        /// </summary>
        public string id
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
        /// <summary>
        /// 考试ID
        /// </summary>
        public string hrm_test_id
        {
            get;
            set;
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime person_start_time
        {
            get;
            set;
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime person_end_time
        {
            get;
            set;
        }
        /// <summary>
        /// 考试得分
        /// </summary>
        public int score
        {
            get;
            set;
        }
    }
}
