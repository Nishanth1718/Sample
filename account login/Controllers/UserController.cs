using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using account_login.Models;

namespace account_login.Controllers
{
    public class UserController : Controller
    {
       [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            regi Usermodel = new regi();
            return View(Usermodel);
        }
        [HttpPost]
        public ActionResult AddorEdit(regi UserModel)
        {
            using (Dbmodels dbmodel = new DbModel())
            {
                dbmodel.regi.Add(UserModel);
                dbmodel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessge = "registration Succesfully.";
            return View("AddorEdit", new regi());
        }

        public ActionResult AddorEdit1(regi UserModel)
        {
            using (Dbmodels dbmodel = new DbModels())
            {
                dbmodel.regi.Add(UserModel);
                dbmodel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessge = "registration Succesfully.";
            return View("AddorEdit", new regi());
        }
    }
}