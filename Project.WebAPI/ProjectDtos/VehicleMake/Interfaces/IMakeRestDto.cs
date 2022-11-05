namespace Project.WebAPI.ProjectDtos.VehicleMake.Interfaces
{
    public interface IMakeRestDto
    {
        int Id { get; set; }
        string MakeName { get; set; }
        string MakeAbrv { get; set; }
    }
}
