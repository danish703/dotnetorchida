using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LMSSystem.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: /<controller>/
        public ViewResult Dash()
        {
            return View();
        }

        public ViewResult Add()
        {
            return View();
        }
    }
}
