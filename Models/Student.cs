using System.ComponentModel.DataAnnotations;

namespace MVCNet6.Models
{
    public class Student
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        public string? Name { get; set; }

        [Range(10,15)]
        public int Id { get; set; }
        public int Age { get; set; }

    }
}
