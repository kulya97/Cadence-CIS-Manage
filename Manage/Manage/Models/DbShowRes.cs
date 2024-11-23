using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.Models
{
    internal class DbShowRes
    {
        [Key]
        public int ID { get; set; }


        public string? Part_Number { get; set; }

        public string? Part_Type { get; set; }
     
        public string? Schematic_Part { get; set; }

        public string? PCB_Footprint { get; set; }
  
        public string? Res_Accuracy { get; set; }

        public int? Sort { get; set; }

        public string? PSpice_Model { get; set; }

        public string? Value { get; set; }

        public string? Description { get; set; }

        public string? SMT { get; set; }

        public string? Price { get; set; }

        public string? Supplier { get; set; }

        public string? Distributor { get; set; }

        public string? Datasheet { get; set; }

        public string? Library_Ref { get; set; }

        public string? Library_Path { get; set; }

        public string? Footprint_Ref { get; set; }

        public string? Footprint_Path { get; set; }
    }
}
