using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApiService.Data;
using ExampleApiService.Models;
using ExampleApiService.Repositories;

namespace ExampleApiService.Services
{
    public class VehicleServices : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Vehicle>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}