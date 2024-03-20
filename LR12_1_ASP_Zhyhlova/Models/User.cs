using System.ComponentModel.DataAnnotations;

namespace LR12_1_ASP_Zhyhlova.Models
{
    class User
    {
        [Key]
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

    }
}
