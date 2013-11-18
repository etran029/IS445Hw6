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
            return Content("invalid input, please try again");
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
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatPhrase(inputPhrase);
                return View((object)formatted);
            }
        }

        private string formatPhrase(string inputPhrase)
        {
            //JavaScript

            //var phraseString = "Hello";
            //return phraseString;

            //C#
            string value = "My Name is Eric";
            string reverse = string.Empty;

            char chSplit = ' ';

            string[] words = value.Split(new char[] { chSplit }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                reverse = word + chSplit + reverse;
            }
            return reverse;
        }

        
    }//end HomeController
}
