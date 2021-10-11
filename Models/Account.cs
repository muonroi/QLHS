using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_C_
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}