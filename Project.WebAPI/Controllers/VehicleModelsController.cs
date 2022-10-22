using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Project.Repository.Common;
using Project.Service;
using Project.Service.Common;
using Project.WebAPI.ProjectDtos.VehicleMake;
using Project.WebAPI.ProjectDtos.VehicleModel;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelsController : ControllerBase
    {
        private readonly IVehicleModelService _vehicleModelService;
        private readonly IMapper _mapper;

        public VehicleModelsController(IVehicleModelService vehicleModelService, IMapper mapper)
        {
            _vehicleModelService = vehicleModelService;
            _mapper = mapper;
        }

        // GET: api/VehicleModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelDto>>> GetVehicleModels()
        {
            var vehicleModels = await _vehicleModelService.GetAllAsync();
            return Ok(_mapper.Map<List<ModelDto>>(vehicleModels));
        }

        // GET: api/VehicleModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelDto>> GetVehicleModel(int id)
        {
            var vehicleModel = await _vehicleModelService.GetAsync(id);

            if (vehicleModel == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ModelDto>(vehicleModel));
        }

        // PUT: api/VehicleModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleModel(ModelDto modelDto)
        {
            var vehicleModel = _mapper.Map<VehicleModel>(modelDto);
            await _vehicleModelService.UpdateAsync(vehicleModel);

            return Ok(vehicleModel);
        }

        // POST: api/VehicleModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleModel>> PostVehicleModel(CreateModelDto createModelDto)
        {
            var vehicleModel = _mapper.Map<VehicleModel>(createModelDto);
            await _vehicleModelService.AddAsync(vehicleModel);

            return CreatedAtAction("GetVehicleModel", new { id = vehicleModel.Id }, vehicleModel);
        }

        // DELETE: api/VehicleModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleModel(int id)
        {
            var vehicleModel = await _vehicleModelService.GetAsync(id);
            if (vehicleModel == null)
            {
                return NotFound();
            }

            await _vehicleModelService.DeleteAsync(id);

            return NoContent();
        }
    }
}
