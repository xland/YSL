using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 系统帐号
    /// </summary>
    public class sys_account
    {
        /// <summary>
        /// 帐号ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 登录名
        /// </summary>
        public string account_name
        {
            get;
            set;
        }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string pass_word
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
        /// 帐号创建时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
    }
}
