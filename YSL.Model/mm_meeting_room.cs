using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 会议室
    /// </summary>
    public class mm_meeting_room
    {
        /// <summary>
        /// 会议室编号
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 会议室名称
        /// </summary>
        public string room_name
        {
            get;
            set;
        }
        /// <summary>
        /// 会议室描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 会议室地址
        /// </summary>
        public string room_address
        {
            get;
            set;
        }
    }
}
