using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 课程文档
    /// </summary>
    public class hrm_course_doc
    {
        /// <summary>
        /// 文档ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 课程ID
        /// </summary>
        public string course_id
        {
            get;
            set;
        }
        /// <summary>
        /// 文档路径
        /// </summary>
        public string doc_url
        {
            get;
            set;
        }
        /// <summary>
        /// 文档描述
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 文档排序
        /// </summary>
        public int order_num
        {
            get;
            set;
        }
        /// <summary>
        /// 是否已过期 
        /// </summary>
        public int is_out_date
        {
            get;
            set;
        }
    }
}
