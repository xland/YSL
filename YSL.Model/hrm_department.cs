using System.ComponentModel.DataAnnotations;
using System;

namespace YSL.Model
{
    /// <summary>
    /// 部门
    /// </summary>
    public class hrm_department
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string department_name
        {
            get;
            set;
        }
        /// <summary>
        /// 部门排序
        /// </summary>
        public int department_order
        {
            get;
            set;
        }
        /// <summary>
        /// 部门描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 上级部门ID
        /// </summary>
        public string pid
        {
            get;
            set;
        }
        /// <summary>
        /// 部门电话、分机号
        /// </summary>
        public string telphone
        {
            get;
            set;
        }
        /// <summary>
        /// 部门负责人
        /// </summary>
        public string department_leader_account_id
        {
            get;
            set;
        }
    }
}
