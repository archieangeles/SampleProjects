using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly Models.IPersonRepository _personRepo;

        public IActionResult Index()
        {
            

            //var model = _personRepo.GetAllPerson().OrderBy(p => p.FirstName);


            var personViewModel = new ViewModels.PersonViewModels()
            {
                Person = _personRepo.GetAllPerson().OrderBy(p => p.FirstName).ToList()
                 ,
                Title = "Sample MVC Core Ko 1.2"
            };

            return View(personViewModel);
        }

        public HomeController(Models.IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }
    }
}