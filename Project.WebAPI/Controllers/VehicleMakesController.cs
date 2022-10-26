using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Models;
using Project.Repository.Common;
using Project.Service.Common;
using Project.WebAPI.ProjectDtos.VehicleMake;
using System.Diagnostics.Metrics;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVehicleMakeService _vehicleMakeService;

        public VehicleMakesController(IMapper mapper, IVehicleMakeService vehicleMakeService)
        {

            _mapper = mapper;
            _vehicleMakeService = vehicleMakeService;
        }

        // GET: api/VehicleMakes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMakeDto>>> GetVehicleMakes()
        {
            var vehicleMakes = await _vehicleMakeService.GetAllAsync();
            var records=_mapper.Map<List<GetMakeDto>>(vehicleMakes);
            return Ok(records);
        }

        // GET: api/VehicleMakes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MakeDto>> GetVehicleMake(int id)
        {
            var vehicleMake = await _vehicleMakeService.GetDetails(id);

            if (vehicleMake == null)
            {
                return NotFound();
            }

            var makeDto=_mapper.Map<MakeDto>(vehicleMake);

            return Ok(makeDto);
        }

        // PUT: api/VehicleMakes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleMake(int id, UpdateMakeDto updateMakeDto)
        {
            if (id != updateMakeDto.Id)
            {
                return BadRequest();
            }

            var vehicleMake = await _vehicleMakeService.GetAsync(id);
            if (vehicleMake == null)
            {
                return NotFound();
            }

            _mapper.Map(updateMakeDto,vehicleMake);

            await _vehicleMakeService.UpdateAsync(vehicleMake);

            return NoContent();
        }

        // POST: api/VehicleMakes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleMake>> PostVehicleMake(CreateMakeDto createMakeDto)
        {
            var vehicleMake=_mapper.Map<VehicleMake>(createMakeDto);
            await _vehicleMakeService.AddAsync(vehicleMake);

            return CreatedAtAction("GetVehicleMakes", new { id = vehicleMake.Id }, vehicleMake);
        }

        // DELETE: api/VehicleMakes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleMake(int id)
        {
            var vehicleMake = await _vehicleMakeService.GetAsync(id);
            if (vehicleMake == null)
            {
                return NotFound();
            }

            await _vehicleMakeService.DeleteAsync(id);

            return NoContent();
        }
    }
}
