using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Model
{
    /// <summary>
    /// 培训项目（一个培训项目下可能会有多个课程）
    /// </summary>
    public class hrm_train
    {
        /// <summary>
        /// 培训ID
        /// </summary>
        public string id
        {
            get;
            set;
        }
        /// <summary>
        /// 培训标题
        /// </summary>
        public string train_title
        {
            get;
            set;
        }
        /// <summary>
        /// 培训备注
        /// </summary>
        public string des
        {
            get;
            set;
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string begin_time
        {
            get;
            set;
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string end_time
        {
            get;
            set;
        }
        /// <summary>
        /// 是否循环培训
        /// </summary>
        public int is_loop
        {
            get;
            set;
        }
        /// <summary>
        /// 循环的类型，0按周，1按月，2按年，3手动
        /// </summary>
        public int loop_type
        {
            get;
            set;
        }
    }
}
