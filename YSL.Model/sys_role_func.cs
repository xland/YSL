using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 角色权限关系实体
    /// </summary>
    public class sys_role_func
    {
        /// <summary>
        /// 角色权限关系实体ID
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
        /// 权限ID
        /// </summary>
        public string func_id
        {
            get;
            set;
        }
    }
}
