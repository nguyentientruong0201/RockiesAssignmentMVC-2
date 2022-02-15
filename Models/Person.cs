namespace MVCNet6;

public class Person {
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string Gender {get; set; }
    public DateTime DateOfBirth { get; set;}
    public string PhoneNumber {get; set; }
    public string BirdPlace { get; set; }
    public int Age {
        get {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
    public bool IsGraduated {get; set;}

}