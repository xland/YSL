using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 物资基类
    /// </summary>
    public class mm_base
    {
        /// <summary>
        /// 物资ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 物资描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 物资价格
        /// </summary>
        public int price
        {
            get;
            set;
        }
        /// <summary>
        /// 负责人员工ID
        /// </summary>
        public string employee_id
        {
            get;
            set;
        }
        /// <summary>
        /// 物资名称
        /// </summary>
        public string mm_name
        {
            get;
            set;
        }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime buy_time
        {
            get;
            set;
        }
        /// <summary>
        /// 物资记录增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 物资记录增加人账户ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 是否已存在异常
        /// </summary>
        public int is_error
        {
            get;
            set;
        }
        /// <summary>
        /// 是否是其他类型的物资
        /// </summary>
        public int is_other
        {
            get;
            set;
        }
    }
}
