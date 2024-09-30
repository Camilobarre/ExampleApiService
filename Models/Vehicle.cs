using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApiService.Models
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("make")]
        public required string Make { get; set; }
        [Column("model")]
        public string Model { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("color")]
        public string Color { get; set; }
    }
}