using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp.Models;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDB itemDatabase = new CoffeeShopDB();

            ViewBag.AllItems = itemDatabase.Items.ToList<Item>();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Successful()
        {
            return View();
        }

        public ActionResult Admin()
        {

            CoffeeShopDB itemDatabase = new CoffeeShopDB();

            ViewBag.AllItems = itemDatabase.Items.ToList<Item>();
            return View();
         
        }
        //add works
        public ActionResult AdminAddPage()
        {
            return View();
        }
        //add works by passing in the allitems viewbag and running a try catch to get more details on expections
        public ActionResult Add(Item newItem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CoffeeShopDB itemDatabase = new CoffeeShopDB();


                    var searchDup = itemDatabase.Items.Where(x => x.ItemName == newItem.ItemName).SingleOrDefault();

                    if(searchDup == null)
                    {
                        itemDatabase.Items.Add(newItem);
                        itemDatabase.SaveChanges();

                        ViewBag.AllItems = itemDatabase.Items.ToList<Item>();
                        return View("Admin");
                    }
                    else
                    {
                        ViewBag.WhereError = "Item Already in database"; 
                        return View("Error");
                    }

                }

                else
                {
                    ViewBag.WhereError = "Model State Not Vaild";
                    return View("Error");

                }
            }
            catch (Exception)
            {
                ViewBag.WhereError = "Exception Error in Add Item";
                return View("Error");
            }
        }

        //doesnt work
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Item findItem)
        {
            CoffeeShopDB itemDatabase = new CoffeeShopDB();

            var item = itemDatabase.Items.Where(x => x.ItemName == findItem.ItemName);


            //itemDatabase.Find(id);
            //db.ColorDBs.Remove(colorDB);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        //doesnt work
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Item findItem)
        {
            CoffeeShopDB itemDatabase = new CoffeeShopDB();

            var item = itemDatabase.Items.Where(x => x.ItemName == findItem.ItemName);


            //itemDatabase.Find(id);
            //db.ColorDBs.Remove(colorDB);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Reg(User newUser)
        {
            if (ModelState.IsValid)
            {
                // ToDo: Send the data to the DB

                CoffeeShopDB userDatabase = new CoffeeShopDB();
                userDatabase.Users.Add(newUser);
                userDatabase.SaveChanges();


                ViewBag.ConfMessage = "Thanks " + newUser.fName;

                return View("Successful");
            }

            else
            {
                return View("Error");

            }
        }
        
    }
}