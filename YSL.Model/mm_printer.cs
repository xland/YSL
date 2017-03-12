using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 打印机
    /// </summary>
    public class mm_printer
    {
        /// <summary>
        /// 打印机ID
        /// </summary>
        public string id
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
        /// <summary>
        /// 是否彩打
        /// </summary>
        public string is_color
        {
            get;
            set;
        }
        /// <summary>
        /// 打印机地址
        /// </summary>
        public string ip_address
        {
            get;
            set;
        }
        /// <summary>
        /// 驱动下载路径
        /// </summary>
        public string drive_url_des
        {
            get;
            set;
        }
        /// <summary>
        /// 驱动ID，多个驱动以英文半角分号隔开
        /// </summary>
        public string drive_id
        {
            get;
            set;
        }
    }
}
