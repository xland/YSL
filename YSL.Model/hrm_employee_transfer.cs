using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 员工转部门记录
    /// </summary>
    public class hrm_employee_transfer
    {
        /// <summary>
        /// 员工转部门ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 来源部门ID
        /// </summary>
        public string from_department_id
        {
            get;
            set;
        }
        /// <summary>
        /// 去向部门ID
        /// </summary>
        public string to_department_id
        {
            get;
            set;
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 转部门的员工ID
        /// </summary>
        public string target_employee_id
        {
            get;
            set;
        }
        /// <summary>
        /// 记录增加帐号ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 记录增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 转部门申请时间
        /// </summary>
        public DateTime apply_time
        {
            get;
            set;
        }
        /// <summary>
        /// 来源部门经理ID
        /// </summary>
        public string from_department_manager_id
        {
            get;
            set;
        }
        /// <summary>
        /// 目标部门经历ID
        /// </summary>
        public string to_department_manager_id
        {
            get;
            set;
        }
    }
}
