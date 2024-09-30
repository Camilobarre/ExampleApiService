using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApiService.DTOs
{
    public class VehicleDTO
    {
        [Required(ErrorMessage = "El campo 'Make' es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo 'Make' no puede tener más de 50 caracteres.")]
        public required string Make { get; set; }

        [Required(ErrorMessage = "El campo 'Model' es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo 'Model' no puede tener más de 50 caracteres.")]
        public required string Model { get; set; }

        [Range(1970, 9999, ErrorMessage = "El año debe estar entre 1970 y 9999.")]
        public int Year { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un número positivo.")]
        public double Price { get; set; }

        [StringLength(30, ErrorMessage = "El campo 'Color' no puede tener más de 30 caracteres.")]
        public string Color { get; set; }
    }
}