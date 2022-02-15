using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCNet6.Models;

namespace MVCNet6.Controllers;

public class PeopleController : Controller
{
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var people = new List<PersonModel>{ 
            new PersonModel{
                Id = 1,
                FirstName = "Le",
                LastName = "Hai",
                Address = "Ha Noi",
                Gender = "Male",
                DateOfBirth = new DateTime(1996,02,01),
                PhoneNumber = "0968034684",
                IsGraduated = true
            },

            new PersonModel{
                Id = 2,
                FirstName = "Nguyen",
                LastName = "Truong",
                Address = "Bac Ninh",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,02,01),
                PhoneNumber = "114",
                IsGraduated = false
            },

            new PersonModel{
                Id = 3,
                FirstName = "Tran",
                LastName = "Ha",
                Address = "Nghe An",
                Gender = "Female",
                DateOfBirth = new DateTime(2002,02,01),
                PhoneNumber = "01265984",
                IsGraduated = false
            }
        };

        return View(people);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(PersonModel model)
    {
        // Add new person logics
        return Content($"This is Person : {model.FirstName}  {model.LastName}, Address : {model.Address}, SĐT : {model.PhoneNumber}, Tuổi : {model.Age}");
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
