using IndrivoFinal.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IndrivoFinal.Controllers
{
    [Authorize(Roles = RoleName.AdminRole)]
    public class UsersController : Controller
    {
        private ApplicationDbContext _application;


        public UsersController()
        {
            _application = new ApplicationDbContext();
        }

        public UsersController(ApplicationDbContext application)
        {
            _application = application;
        }

        public ActionResult Index()
        {

            return View(_application.Users.ToList());
        }
    }
}