using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 打印机驱动
    /// </summary>
    public class mm_printer_drive
    {
        /// <summary>
        /// 打印机驱动ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 驱动下载地址
        /// </summary>
        public string drive_url
        {
            get;
            set;
        }
        /// <summary>
        /// 驱动名称
        /// </summary>
        public string drive_name
        {
            get;
            set;
        }
        /// <summary>
        /// 增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 增加帐号ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
    }
}
