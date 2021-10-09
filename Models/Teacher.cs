using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_C_
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [Column("ID")]
        public int CodeGv { get; set; }
        [Required]
        [Column("Name Class")]
        public string ClassRoom { get; set; }
        [Required]
        [Column("Number of Class",TypeName ="int")]
        public int NumberOfClass{get;set;}
        public List<Students> students {get;set;}

    }
}