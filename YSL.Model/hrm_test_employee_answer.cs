using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 员工答卷情况
    /// </summary>
    public class hrm_test_employee_answer
    {
        /// <summary>
        /// 员工答卷情况ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 答卷员工账户ID
        /// </summary>
        public string employee_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 试卷ID
        /// </summary>
        public string test_id
        {
            get;
            set;
        }
        /// <summary>
        /// 问题ID
        /// </summary>
        public string test_question_id
        {
            get;
            set;
        }
        /// <summary>
        /// 主观题回答内容
        /// </summary>
        public string employee_answer_num
        {
            get;
            set;
        }
        /// <summary>
        /// 客观题回答内容
        /// </summary>
        public string employee_answer
        {
            get;
            set;
        }
    }
}
