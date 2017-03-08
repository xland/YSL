using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 消息
    /// </summary>
    public class sys_msg
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 消息标题
        /// </summary>
        public string msg_title
        {
            get;
            set;
        }
        /// <summary>
        /// 消息正文
        /// </summary>
        public int msg_content
        {
            get;
            set;
        }
        /// <summary>
        /// 来源账户ID，account_id；如果该字段为sys的话，则该消息为系统发送的消息；
        /// </summary>
        public string from_id
        {
            get;
            set;
        }
        /// <summary>
        /// 目标账户ID，account_id
        /// </summary>
        public string to_id
        {
            get;
            set;
        }
        /// <summary>
        /// 是否已读
        /// </summary>
        public int is_viewd
        {
            get;
            set;
        }
        /// <summary>
        /// 阅读时间
        /// </summary>
        public DateTime view_time
        {
            get;
            set;
        }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime send_time
        {
            get;
            set;
        }
    }
}
