using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 部门员工关系实体
    /// </summary>
    public class HrmDepartmentEmployee
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
        /// 部门ID
        /// </summary>
        public string department_id
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
    }
}
