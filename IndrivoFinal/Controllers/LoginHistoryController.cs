using IndrivoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndrivoFinal.Controllers
{
    [Authorize(Roles = RoleName.AdminRole)]
    public class LoginHistoryController : Controller
    {
        private ApplicationDbContext _context;

        public LoginHistoryController()
        {
            _context = new ApplicationDbContext();
        }

        public ViewResult Index()
        {
            var loginHistory = _context.LoginHistories.ToList();
            return View(loginHistory);
        }
    }
}