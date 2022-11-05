using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Interfaces
{
    public interface IPage<T>
    {
        List<T> Items { get; set; }

        string Filter { get; set; }

        string SortOrder { get; set; }

        int PgIndex { get; set; }

        int NumOfPages { get; set; }
    }
}
