using Project.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Page<T>:IPage<T>
    {
        public List<T> Items { get; set; }
        public string Filter { get; set; }
        public string SortOrder { get; set; }
        public int PgIndex { get; set; }
        public int NumOfPages { get; set; }
    }
}
