using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syosetu_Crawler
{
    /// <summary>
    /// 小說類別
    /// </summary>
    class Novels
    {
        /// <summary>
        /// 小說名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 章節名稱
        /// </summary>
        public string ChapterTitle { get; set; }
        /// <summary>
        /// 章節內文
        /// </summary>
        public string ChapterContext { get; set; }
    }
}
