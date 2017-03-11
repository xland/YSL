using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 课程
    /// </summary>
    public class hrm_course
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        public string id
        {
            get;
            set;            
        }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string course_name
        {
            get;
            set;
        }
        /// <summary>
        /// 课程描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 课程难度系数
        /// </summary>
        public int level
        {
            get;
            set;
        }
    }
}
