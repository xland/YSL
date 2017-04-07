using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

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
        public int order_num
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
        /// 部门负责人帐号ID
        /// </summary>
        public string leader_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 部门负责人ID
        /// </summary>
        public string leader_employee_id
        {
            get;
            set;
        }
        /// <summary>
        /// 部门负责人姓名（冗余数据）
        /// </summary>
        public string leader_name
        {
            get;
            set;
        }
        [NotMapped]
        public List<hrm_department> children
        {
            get;
            set;
        }
    }
}
