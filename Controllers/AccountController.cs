using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolApp.Models;
using System.Web.Security;
using System.Data.Entity;
using SchoolApp.Data;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace SchoolApp.Controllers
{
    public class AccountController : Controller
    {
        private SchoolAppContext db = new SchoolAppContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel Credentials)
        {
            bool UserExist = db.Users.Any(x => x.Username == Credentials.Username && x.Password == Credentials.Password);
            User u = db.Users.FirstOrDefault(x => x.Username == Credentials.Username && x.Password == Credentials.Password);

            if (UserExist)
            {
                FormsAuthentication.SetAuthCookie(u.Username, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Username or Password is incorrect");

            return View();
        }

        [HttpPost]
        public ActionResult Register(User userinfo)
        {
            db.Users.Add(userinfo);
            userinfo.JoinDate = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}