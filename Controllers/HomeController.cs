using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return Content("Invalid input, please try again");
          }
          else
          {
            string formatted = formatNumber(inputNumber);
            return View((object)formatted);
          }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
          // imiplement formatting here

            //JavaScript
            var first = inputNumber.Substring(0, 3);
            var second = inputNumber.Substring(3, 3);
            var third = inputNumber.Substring(6, 4);
            var phoneString = "(" + first + ") " + second + "-" + third + ".";
          return phoneString;

            //C#

        }

        public ActionResult TaskTwo()
        {
            return View();
        }

        public ActionResult FormatPhraseReverse(string inputPhrase)
        {
            if (string.IsNullOrEmpty(inputPhrase))
            {
                return Content("Invalid input, please try again");
            }
            else
            {
                string[] words = inputPhrase.Split(' ');

                string reverse = "";

                foreach (string part in words)
                {
                    reverse = part + " " + reverse;
                }

                return View((object)reverse);
            }
        }
        
    }//end HomeController
}
