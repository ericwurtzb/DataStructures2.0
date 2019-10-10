using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures2._0.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: Dictionary
        static Dictionary<int, string> myDict = new Dictionary<int, string>();

        public ActionResult IndexD()
        {
            ViewBag.Dict = myDict;
            return View();
        }

        public ActionResult AddOne()
        {
            myDict.Add(myDict.Keys.Last() + 1, String.Concat("New Entry ", myDict.Keys.Last() + 1));

            ViewBag.Dict = myDict;

            return View("IndexD");
        }

        public ActionResult AddHuge()
        {
            myDict.Clear();
            int numToAdd = 2000;

            for (var iCount = 1; iCount <= numToAdd; iCount++)
            {
                myDict.Add(iCount, String.Concat("New Entry ", iCount));
            }
            ViewBag.Dict = myDict;
            return View("IndexD");
        }

        public ActionResult Display()
        {
            ViewBag.Dict = myDict;
            return View("IndexD");
        }
        public ActionResult DeleteFrom()
        {
            //deleting
            //return a view first
            //on submit perform the function

            return View()
        }
        public ActionResult Clear()
        {
            myDict.Clear();
            ViewBag.Dict = myDict;

            return View("IndexD");
        }
        public ActionResult Search()
        {

        }
        public ActionResult Return()
        {
            return View("Index", "Home");
        }
    }
}