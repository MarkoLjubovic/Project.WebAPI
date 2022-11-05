using Project.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common
{
    public class PageInfo:IPageInfo
    {
        public int PgIndex { get; set; } = 0;
        public string Filter { get; set; } = "";
        public string SortOrder { get; set; } = "";
        public int NumOfPages { get; set; }
        public int PgSize { get; set; } = 5;
    }
}
