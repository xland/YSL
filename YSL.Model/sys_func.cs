using System;
using System.ComponentModel.DataAnnotations;

namespace YSL.Model
{
    /// <summary>
    /// 系统权限
    /// </summary>
    public class sys_func
    {
        /// <summary>
        /// 功能ID
        /// </summary>
        [Key]
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 功能名称
        /// </summary>
        public string func_name
        {
            get;
            set;
        }
        /// <summary>
        /// 功能排序
        /// </summary>
        public int order_num
        {
            get;
            set;
        }
        /// <summary>
        /// 父级功能ID
        /// </summary>
        public int pid
        {
            get;
            set;
        }
        /// <summary>
        /// 功能路径
        /// </summary>
        public string path
        {
            get;
            set;
        }
        /// <summary>
        /// 功能描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
    }
}
