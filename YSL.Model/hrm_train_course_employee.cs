using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 受训人员
    /// </summary>
    public class hrm_train_course_employee
    {
        /// <summary>
        /// 受训人员ID
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
        /// 是否必培
        /// </summary>
        public int is_have_to
        {
            get;
            set;
        }
        /// <summary>
        /// 培训课程计划ID
        /// </summary>
        public string hrm_train_course_id
        {
            get;
            set;
        }
    }
}
