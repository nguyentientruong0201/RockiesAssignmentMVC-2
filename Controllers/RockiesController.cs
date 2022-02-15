using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCNet6.Models;

namespace MVCNet6.Controllers;

public class RockiesController : Controller
{
     static List<Person> person = new List<Person>
        {
            new Person {
                FirstName = "Truong",
                LastName = "Nguyen Tien",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,02,01),
                PhoneNumber = "",
                BirdPlace = "Phu Tho",
                IsGraduated = false
            },
            new Person {
                FirstName = "Thanh",
                LastName = "Nguyen Tien",
                Gender = "Male",
                DateOfBirth = new DateTime(1999,02,01),
                PhoneNumber = "",
                BirdPlace = "ha noi",
                IsGraduated = false
            },
            new Person {
                FirstName = "Ha",
                LastName = "Pham Thu",
                Gender = "Female",
                DateOfBirth = new DateTime(1996,02,01),
                PhoneNumber = "",
                BirdPlace = "ha noi",
                IsGraduated = false
            },
            new Person {
                FirstName = "Chien",
                LastName = "Nguyen Tien",
                Gender = "Male",
                DateOfBirth = new DateTime(2002,02,01),
                PhoneNumber = "",
                BirdPlace = "Bac Ninh",
                IsGraduated = false
            },

        };
   //cau a
     [Route("rockies/male")]
        public IActionResult GetMaleMembers() {
            var results = person.Where(x => x.Gender == "Male").ToList();
            return new ObjectResult(results);
            
            //return Content("Hello world!");
        }
    // cau b
     [Route("rockies/oldest")]
     public IActionResult GetOldestMembers() {
        var maxAge = person.Max(m => m.Age);
        var oldest = person.First(m => m.Age == maxAge);
        return new ObjectResult(oldest);

     }

     [Route("rockies/fullname")]
     public IActionResult GetFullNames() {
         var fullnames = person.Select(m => m.FirstName);
         return new ObjectResult(fullnames);
     }

     [Route("rockies/split-people-by-birth-year/{year:int}")]

     public IActionResult SplitPeopleByBirthYear(int year) {
          
         return Content($"year: {year}");

     }

     [Route("rockies/export")]

     public IActionResult Export() {
         return new EmptyResult();
     }
       
}