using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TehnokratProject.Models;

namespace TehnokratProject.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Phone()
        {
            return View();
        }

        public IActionResult Laptop()
        {
            return View();
        }

        public IActionResult Printer()
        {
            return View();
        }

        public IActionResult TV()
        {
            return View();
        }
        ///

        public IActionResult Tablet()
        {
            return View();
        }
        
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Services() // �������
        {
            return View();
        }

        public IActionResult about() // �������
        {
            return View();
        }

        //public IActionResult Services() // �������
        //{
        //    return View();
        //}

        //public IActionResult Services() // �������
        //{
        //    return View();
        //}
    }
}
