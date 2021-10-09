using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_C_
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("Students Code")]
        public int StudentCode { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Classroom { get; set; }
        public double ScoreMath { get; set; }
        public double ScoreChemical { get; set; }
        public double ScorePhysics { get; set; }
        public double ScoreAverage { get; set; }
        public int PhoneNumber { get; set; }
        public string Lesson { get; set; }
        public double ListAverageScore { get; set; }
        public int TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public Teacher IDTeacher { get; set; }
    }
}