using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6_13_2_.Models;

namespace WebApplication6_13_2_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string text)
        {
            indexViewModel ivm =  new indexViewModel();
            text = text == null ? text : text.ToUpper();
            ivm.AlphabetCount = GetalphabetCount(text);
            ivm.text = text;
            return View(ivm);
        }

        static Dictionary<char, int> GetalphabetCount(string text)
        {
            Dictionary<char, int> alphabetCount = new Dictionary<char, int>();
            foreach (char c in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            {
                alphabetCount.Add(c, 0);
            }
            if(text != null)
            {
                foreach (char c in text)
                {
                    if (alphabetCount.ContainsKey(c))
                    {
                        alphabetCount[c]++;
                    }
                }

            }
           
            return alphabetCount;
        }


    }
}