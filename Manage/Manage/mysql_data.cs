using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manage
{

    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
