using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace YSL.Model
{
    /// <summary>
    /// 员工
    /// </summary>
    public class hrm_employee
    {
        /// <summary>
        /// 用工ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string employee_name
        {
            get;
            set;
        }
        /// <summary>
        /// 员工性别：0女，1男，2未知
        /// </summary>
        public int sex
        {
            get;
            set;
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string id_num
        {
            get;
            set;
        }
        /// <summary>
        /// 员工编号
        /// </summary>
        public int emp_num
        {
            get;
            set;
        }
        /// <summary>
        /// 是否已婚：0未婚，1已婚，2未知
        /// </summary>
        public int marriage
        {
            get;
            set;
        }
        /// <summary>
        /// 孩子数量：0未生育
        /// </summary>
        public int childrenNum
        {
            get;
            set;
        }
        /// <summary>
        /// 到岗时间
        /// </summary>
        public DateTime in_time
        {
            get;
            set;
        }
        /// <summary>
        /// 转正时间
        /// </summary>
        public DateTime regular_time
        {
            get;
            set;
        }
        /// <summary>
        /// 常用号码
        /// </summary>
        public string phone_num
        {
            get;
            set;
        }
        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string emergency_name
        {
            get;
            set;
        }
        /// <summary>
        /// 紧急联系电话
        /// </summary>
        public string emergency_phone_num
        {
            get;
            set;
        }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime birthday
        {
            get;
            set;
        }
        /// <summary>
        /// 员工状态: -2未入职，但已发offer；-1未转正；1正式员工；2已提出离职；3已离职；
        /// </summary>
        public int employee_state
        {
            get;
            set;
        }
        /// <summary>
        /// 员工增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 员工座机号码，分机号
        /// </summary>
        public string telphone
        {
            get;
            set;
        }
    }
}
