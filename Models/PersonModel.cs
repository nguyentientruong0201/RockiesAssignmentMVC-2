using System.ComponentModel;
namespace MVCNet6.Models
{
    public class PersonModel
    {
        public int Id { get; set; } 
        
        public string LastName { get; set; }
        public string FirstName {get;set;}
        public string Address {get;set;}
        public string? Gender {get;set;}
        public DateTime DateOfBirth { get; set;}
        public string PhoneNumber {get; set;}

        public int Age {
        get {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
        }
        
        public bool IsGraduated {get; set;}

    }

    public enum Gender {
        Male,
        Female,
        Other
    }
}