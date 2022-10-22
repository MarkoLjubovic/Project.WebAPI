using Project.WebAPI.ProjectDtos.VehicleModel;

namespace Project.WebAPI.ProjectDtos.VehicleMake
{
    public class MakeDto
    {
        public int Id { get; set; }
        public string MakeName { get; set; }
        public string MakeAbrv { get; set; }

        public List<ModelDto> VehicleModels { get; set; }
    }

}
