using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace EquipmentService.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
