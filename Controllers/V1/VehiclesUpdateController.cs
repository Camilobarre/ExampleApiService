using ExampleApiService.Data;
using ExampleApiService.DTOs;
using ExampleApiService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApiService.Controllers.V1.Vehicles;

[ApiController]
[Route("api/v1/[controller]")]
[Route("api/v1/vehicles")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("vehicles")]
public class VehiclesUpdateController : ControllerBase
{
    private readonly IVehicleRepository _vehicleRepository;

    public VehiclesUpdateController(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, VehicleDTO updatedVehicle)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var checkVehicle = await _vehicleRepository.CheckExistence(id);
        if (checkVehicle == false)
        {
            return NotFound();
        }

        var vehicle = await _vehicleRepository.GetById(id);

        if (vehicle == null)
        {
            return NotFound();
        }

        vehicle.Make = updatedVehicle.Make;
        vehicle.Model = updatedVehicle.Model;
        vehicle.Year = updatedVehicle.Year;
        vehicle.Price = updatedVehicle.Price;
        vehicle.Color = updatedVehicle.Color;

        await _vehicleRepository.Update(vehicle);
        return NoContent();
    }
}