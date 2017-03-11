using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 课程计划
    /// </summary>
    public class hrm_train_course
    {
        /// <summary>
        /// 课程计划ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 课程计划开始时间
        /// </summary>
        public DateTime begin_time
        {
            get;
            set;
        }
        /// <summary>
        /// 课程计划结束时间
        /// </summary>
        public DateTime end_time
        {
            get;
            set;
        }
        /// <summary>
        /// 课程计划描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 内部课程会议室ID
        /// </summary>
        public string meeting_room_id
        {
            get;
            set;
        }
        /// <summary>
        /// 是否是外部课程
        /// </summary>
        public int is_external
        {
            get;
            set;
        }
        /// <summary>
        /// 外部课程省ID
        /// </summary>
        public string province_id
        {
            get;
            set;
        }
        /// <summary>
        /// 外部课程市ID
        /// </summary>
        public string city_id
        {
            get;
            set;
        }
        /// <summary>
        /// 外部课程县ID
        /// </summary>
        public string area_id
        {
            get;
            set;
        }
        /// <summary>
        /// 外部课程的具体地址
        /// </summary>
        public string address
        {
            get;
            set;
        }
        /// <summary>
        /// 课程是否已完成：0已完成；
        /// </summary>
        public int is_end
        {
            get;
            set;
        }
    }
}
