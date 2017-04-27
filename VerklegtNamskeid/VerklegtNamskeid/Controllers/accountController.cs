using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VerklegtNamskeid.Models;


namespace VerklegtNamskeid.Controllers
{
    public class accountController : Controller
    {
        // GET: account
        public ActionResult Index()
        {
            using (ourDbContext db = new ourDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if(ModelState.IsValid)
            {
                using (ourDbContext db = new ourDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account._userName + " " + account._userEmail + " successfully registered.";
            }
            return View();
        }

        //login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using(ourDbContext db = new ourDbContext())
            {
                var usr = db.userAccount.Single(u => u._userName == user._userName && u._userPassword == user._userPassword); 
                if(usr != null)
                {
                    Session["_userID"] = usr._userID.ToString();
                    Session["_userName"] = usr._userName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("","Username or password is wrong.");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if(Session["_userID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}