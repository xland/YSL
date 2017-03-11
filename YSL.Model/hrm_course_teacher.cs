using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 课程讲师
    /// </summary>
    public class hrm_course_teacher
    {
        /// <summary>
        /// 讲师ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 内部讲师员工ID
        /// </summary>
        public string employee_id
        {
            get;
            set;
        }
        /// <summary>
        /// 内部讲师帐号ID
        /// </summary>
        public string account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 是否内部员工
        /// </summary>
        public string is_external
        {
            get;
            set;
        }
        /// <summary>
        /// 外部讲师名称
        /// </summary>
        public string teacher_name
        {
            get;
            set;
        }
        /// <summary>
        /// 课程ID
        /// </summary>
        public string course_id
        {
            get;
            set;
        }
    }
}
