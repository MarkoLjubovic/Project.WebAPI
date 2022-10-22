using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class VehicleMake
    {
        public int Id { get; set; }
        public string MakeName { get; set; }
        public string MakeAbrv { get; set; }
        public virtual IList<VehicleModel> VehicleModels { get; set; }
    }
}
