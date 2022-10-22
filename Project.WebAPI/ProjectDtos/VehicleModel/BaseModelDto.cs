using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.WebAPI.ProjectDtos.VehicleModel
{
    public class BaseModelDto
    {
        [Required]
        public string ModelName { get; set; }
        public string ModelAbrv { get; set; }
        [Required]
        public int MakeId { get; set; }
    }
}
