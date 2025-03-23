using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchPicker.Models
{
    public class Restaurant
    {
        public required string Name { get; set; }
        public string? Cuisine { get; set; }
        public required string Location { get; set; }
    }
}