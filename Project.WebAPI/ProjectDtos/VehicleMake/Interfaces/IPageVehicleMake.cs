using Project.WebAPI.ProjectDtos.VehicleMake.Interfaces;

namespace Project.WebAPI.ProjectDtos.VehicleMake
{
    public interface IPageVehicleMake
    {
        public List<IMakeRestDto> Items { get; set; }
        public int NumOfPages { get; set; }
        public int PgIndex { get; set; }
        public string Filter { get; set; }
        public string SortOrder { get; set; }
    }
}
