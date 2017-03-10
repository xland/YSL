using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 题库里的题目
    /// </summary>
    public class hrm_question
    {
        /// <summary>
        /// 题目ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 题目名称
        /// </summary>
        public string title
        {
            get;
            set;
        }
        /// <summary>
        /// 题目分数
        /// </summary>
        public int score
        {
            get;
            set;
        }
        /// <summary>
        /// 题目类型：0选择题;1问答题
        /// </summary>
        public int question_type
        {
            get;
            set;
        }
        /// <summary>
        /// 题目增加时间
        /// </summary>
        public DateTime add_time
        {
            get;
            set;
        }
        /// <summary>
        /// 增加题目的账户ID
        /// </summary>
        public string add_account_id
        {
            get;
            set;
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int is_delete
        {
            get;
            set;
        }
        /// <summary>
        /// 问答题的标准答案
        /// </summary>
        public string standard_answer
        {
            get;
            set;
        }
        /// <summary>
        /// 选择题的标准答案
        /// </summary>
        public int standard_answer_num
        {
            get;
            set;
        }
    }
}
