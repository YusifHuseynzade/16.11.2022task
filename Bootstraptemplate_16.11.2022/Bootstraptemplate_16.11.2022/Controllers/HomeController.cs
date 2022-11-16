using Bootstraptemplate_16._11._2022.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bootstraptemplate_16._11._2022.Controllers
{
    public class HomeController : Controller
    {
        private List<Service> _services;

        public HomeController()
        {
            _services = new List<Service>
            {
                new Service{Title="Lorem Ipsum", Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
                new Service{Title="Sed ut perspiciatis", Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
                new Service{Title="Magni Dolores", Description="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
                new Service{Title="Nemo Enim", Description="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
                new Service{Title="Dele cardo", Description="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
                new Service{Title="Divera don", Description="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"},
            };
        }
        public ViewResult Index()
        {
            List<Service> services = _services;
           
            return View(services);
        }

        public ViewResult About()
        {

            return View();
        }

        public ViewResult Services()
        {
            List<Service> services = _services;

            return View(services);
        }
    }
}
