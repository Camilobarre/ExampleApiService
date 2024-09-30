using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApiService.Data;
using ExampleApiService.DTOs;
using ExampleApiService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApiService.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleCreateController : ControllerBase
    {
private readonly ApplicationDbContext _context;

[HttpPost]
public async Task<IActionResult> Create([FromBody] VehicleDTO inputVehicle)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    var newVehicle = new Vehicle
    {
        Make = inputVehicle.Make,
        Model = inputVehicle.Model,
        Year = inputVehicle.Year,
        Price = inputVehicle.Price,
        Color = inputVehicle.Color
    };

    _context.Vehicles.Add(newVehicle);
    await _context.SaveChangesAsync();

    return CreatedAtAction(string.Empty, newVehicle);
}

    }
}