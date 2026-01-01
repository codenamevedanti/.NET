using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Key]
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column("address", TypeName = "varchar(50)")]
        public string? Address { get; set; }
    }
}
