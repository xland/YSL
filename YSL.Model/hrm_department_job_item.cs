using System.ComponentModel.DataAnnotations;
using System;

namespace YSL.Model
{
    /// <summary>
    /// 部门招聘岗位细项
    /// </summary>
    public class hrm_department_job_item
    {
        /// <summary>
        /// 部门招聘岗位实体ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 部门招聘岗位细项类型：0为岗位要求；1为岗位职责
        /// </summary>
        public int item_type
        {
            get;
            set;
        }
        /// <summary>
        /// 部门招聘岗位细项描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 是否必备技能：1为是，0为不是（只有类型为岗位要求的时候，才会填写此字段）
        /// </summary>
        public int is_necessary
        {
            get;
            set;
        }
        /// <summary>
        /// 部门招聘岗位细项所对应的招聘岗位的ID
        /// </summary>
        public string job_id
        {
            get;
            set;
        }
    }
}
