using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Manage.Models.Table
{

    [Table("001电阻")]
    public class RES
    {
        [Key]
        public int ID { get; set; }

        [Column("Part_Number")]
        public string? Part_Number { get; set; }
        [Column("Part_Type")]
        public string? Part_Type { get; set; }
        [Column("Schematic_Part")]
        public string? Schematic_Part { get; set; }
        [Column("PCB_Footprint")]
        public string? PCB_Footprint { get; set; }
        [Column("精度")]
        public string? Res_Accuracy { get; set; }
        [Column("阻值排序")]
        public int? Sort { get; set; }
        [Column("PSpice_Model")]
        public string? PSpice_Model { get; set; }
        [Column("Value")]
        public string? Value { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
        [Column("嘉立创SMT")]
        public string? SMT { get; set; }
        [Column("Price")]
        public string? Price { get; set; }
        [Column("供货商")]
        public string? Supplier { get; set; }
        [Column("Distributor")]
        public string? Distributor { get; set; }
        [Column("Datasheet")]
        public string? Datasheet { get; set; }
        [Column("Library Ref")]
        public string? Library_Ref { get; set; }
        [Column("Library Path")]
        public string? Library_Path { get; set; }
        [Column("Footprint Ref")]
        public string? Footprint_Ref { get; set; }
        [Column("Footprint Path")]
        public string? Footprint_Path { get; set; }
    }
}
