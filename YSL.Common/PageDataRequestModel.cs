using System;
using System.Collections.Generic;
using System.Text;

namespace YSL.Common
{
    public class PageDataRequestModel
    {
        private int _page_size = 38;
        private int _page_index = 0;
        /// <summary>
        /// 起始页，默认值为0
        /// </summary>
        public int page_index
        {
            get
            {
                return _page_index;
            }
            set
            {
                _page_index = value;
            }
        }
        /// <summary>
        /// 页面行数，默认值为38
        /// </summary>
        public int page_size
        {
            get
            {
                return _page_size;
            }
            set
            {
                _page_size = value;
            }
        }
    }
}
