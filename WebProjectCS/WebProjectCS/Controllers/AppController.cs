using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebProjectCS.Models.Managment;

namespace WebProjectCS.Controllers
{
    public class App : Controller
    {
        public void addViewBags()
        {
            ViewBag.sessionvId = HttpContext.Session.GetInt32("UserID");
            ViewBag.sessionvName = HttpContext.Session.GetString("UserName");
            ViewBag.sessionvPriv = HttpContext.Session.GetInt32("UserPriv");

        }

        public IActionResult Index()
        {
            
            bool usr_connected;
            try
            {
                usr_connected = (HttpContext.Session.Get("UserID") != null);

            }
            catch (Exception e)
            {
                usr_connected = false; // no session has been set
            }
            if (usr_connected)
            {
                addViewBags();
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

        public IActionResult Register()
        {
            
            return View();
        }

        public IActionResult Contact()
        {
            addViewBags();
            return View();
        }


        public IActionResult About()
        {
            addViewBags();
            return View();
        }

        public IActionResult Blog()
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                addViewBags();
                var convBlogItem = db.convBlogItem;

                return View(convBlogItem.ToList());
            }
        }

        public IActionResult CyberNews()
        {
            addViewBags();
            return View();
        }

        public IActionResult Settings()
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {
                addViewBags();
                var user = db.userAccount;
                return View(user.ToList());
            }
        }

        [HttpPost]
        public IActionResult Register(UserAcccount account)
        {
            try
            {
                addViewBags();
            }
            catch (Exception e) { Console.WriteLine(e.StackTrace); }
            if (ModelState.IsValid)
            {
                using (ApplicationDbContextcs db = new ApplicationDbContextcs())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " Successfully registered."; 
            }
            return View();
        }

        //
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserAcccount user)
        {
            using (ApplicationDbContextcs db = new ApplicationDbContextcs())
            {

                try
                {
                    var usr =  db.userAccount.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                    HttpContext.Session.SetInt32("UserID", usr.UId);
                    HttpContext.Session.SetString("UserName", usr.UserName.ToString());
                    HttpContext.Session.SetInt32("UserPriv", usr.UPriv);
                    return Redirect("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "UserName or Password is wrong!");
                }
            }
            return View();
        }

        public IActionResult LoggedIn()
        {
            if (HttpContext.Session.Get("UserID") != null)
            {
                addViewBags();
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}