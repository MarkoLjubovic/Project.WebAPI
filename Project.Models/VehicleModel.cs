using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string ModelAbrv { get; set; }

        [ForeignKey(nameof(MakeId))]
        public int MakeId { get; set; }
        public VehicleMake VehicleMake { get; set; }
    }
}
