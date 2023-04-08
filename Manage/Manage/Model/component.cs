using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.Model
{
    public abstract class Component
    {
        public string? ID { get; set; }
        public string? Part_Number { get; set; }
        public string? Part_Type { get; set; }
        public string? Schematic_Part { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public string? PCB_Footprint { get; set; }
        public string? PSpice_Model { get; set; }
        public string? Stock { get; set; }
    }
}
