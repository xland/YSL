using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 电脑
    /// </summary>
    public class mm_computer
    {
        /// <summary>
        /// 电脑ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 电脑名称
        /// </summary>
        public string computer_name
        {
            get;
            set;
        }
        /// <summary>
        /// CPU名称
        /// </summary>
        public string CPU_name
        {
            get;
            set;
        }
        /// <summary>
        /// 内存名称
        /// </summary>
        public string RAM_name
        {
            get;
            set;
        }
        /// <summary>
        /// CPU配置
        /// </summary>
        public string CPU_num
        {
            get;
            set;
        }
        /// <summary>
        /// 内存配置
        /// </summary>
        public string RAM_num
        {
            get;
            set;
        }
        /// <summary>
        /// 磁盘名称
        /// </summary>
        public string disk_name
        {
            get;
            set;
        }
        /// <summary>
        /// 磁盘配置
        /// </summary>
        public string disk_num
        {
            get;
            set;
        }
        /// <summary>
        /// 是否为笔记本电脑
        /// </summary>
        public int is_laptop
        {
            get;
            set;
        }
        /// <summary>
        /// 显示器名称
        /// </summary>
        public string LCD_name
        {
            get;
            set;
        }
        /// <summary>
        /// 显示器配置
        /// </summary>
        public string LCD_num
        {
            get;
            set;
        }
        /// <summary>
        /// 物资基类ID
        /// </summary>
        public string mm_base_id
        {
            get;
            set;
        }
    }
}
