using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 考试
    /// </summary>
    public class hrm_test
    {
        /// <summary>
        /// 考试ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 考试名称
        /// </summary>
        public string test_name
        {
            get;
            set;
        }
        /// <summary>
        /// 考试创建时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 创建考试的账户ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 考试开始时间
        /// </summary>
        public DateTime test_begin_time
        {
            get;
            set;
        }
        /// <summary>
        /// 考试结束时间
        /// </summary>
        public DateTime test_end_time
        {
            get;
            set;
        }
    }
}
