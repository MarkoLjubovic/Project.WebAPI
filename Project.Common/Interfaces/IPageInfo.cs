using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Interfaces
{
    public interface IPageInfo
    {
        int PgIndex { get; set; }
        string Filter { get; set; }
        string SortOrder { get; set; }
        int NumOfPages { get; set; }
        int PgSize { get; set; }
    }
}
