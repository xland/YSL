using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 系统日志
    /// </summary>
    public class sys_log
    {
        /// <summary>
        /// 日志ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 帐号ID
        /// </summary>
        public string account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 日志标题
        /// </summary>
        public string log_title
        {
            get;
            set;
        }
        /// <summary>
        /// 日志详情
        /// </summary>
        public string log_detail
        {
            get;
            set;
        }
        /// <summary>
        /// 来源IP
        /// </summary>
        public string source_ip
        {
            get;
            set;
        }
        /// <summary>
        /// 日志创建时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
    }
}
