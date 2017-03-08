using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 帐号角色关系实体
    /// </summary>
    public class sys_account_role
    {
        /// <summary>
        /// 帐号角色关系实体ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 角色ID
        /// </summary>
        public string role_id
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
    }
}
