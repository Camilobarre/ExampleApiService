using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApiService.Models;

namespace ExampleApiService.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();
        Task<Vehicle> GetById(int id);
    }
}