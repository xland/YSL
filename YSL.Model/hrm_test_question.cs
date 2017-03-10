using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 试卷与问题的关系实体
    /// </summary>
    public class hrm_test_question
    {
        /// <summary>
        /// 试卷与问题的关系实体ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 问题ID
        /// </summary>
        public string question_id
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
        /// 题目排序
        /// </summary>
        public string order_num
        {
            get;
            set;
        }
    }
}
