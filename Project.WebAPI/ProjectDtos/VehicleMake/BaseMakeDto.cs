using System.ComponentModel.DataAnnotations;

namespace Project.WebAPI.ProjectDtos.VehicleMake
{
    public abstract class BaseMakeDto
    {
        [Required]
        public string MakeName { get; set; }
        public string MakeAbrv { get; set; }
    }
}
