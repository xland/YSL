using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 系统角色
    /// </summary>
    public class sys_role
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string role_name
        {
            get;
            set;
        }
        /// <summary>
        /// 角色排序
        /// </summary>
        public int order_num
        {
            get;
            set;
        }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
    }
}
