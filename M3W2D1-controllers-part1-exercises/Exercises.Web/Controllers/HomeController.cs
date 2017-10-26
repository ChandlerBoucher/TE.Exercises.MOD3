using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;
using System.Runtime.InteropServices;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ordered Name
        public ActionResult OrderedName()
        {
            return View();
        }

        public ActionResult OrderedNameResult(string FirstName, string LastName, string MiddleInitial, int Order)
        {
            Name model = new Name();
            model.firstName = FirstName;
            model.middleInitial = MiddleInitial;
            model.lastName = LastName;
            model.order = Order;
            return View(model);
        }

        //GET: Colored Name
        public ActionResult ColoredName()
        {
            return View();
        }

        public ActionResult ColoredNameResult(string FirstName, string LastName, string MiddleInitial, string Color1, string Color2, string Color3)
        {
            Name model = new Name();
            model.colors = new List<string>();
            model.firstName = FirstName;
            model.lastName = LastName;
            model.middleInitial = MiddleInitial;
            if (Color1 != null)
            {
                model.colors.Add(Color1);
            }
            if (Color2 != null)
            {
                model.colors.Add(Color2);
            }
            if (Color3 != null)
            {
                model.colors.Add(Color3);
            }
            return View(model);
        }

        //GET: Fizz Buzz for Five
        public ActionResult FizzBuzzFive()
        {
            return View();
        }

        //GET: FizzBuzzFiveResult
        public ActionResult FizzBuzzResult(int div1, int div2, string fizz, string buzz, int num1, int num2, int num3, int num4, int num5)
        {
            FizzBuzzer model = new FizzBuzzer();
            model.fizzer = fizz;
            model.buzzer = buzz;
            model.div1 = div1;
            model.div2 = div2;
            model.input.Add(num1);
            model.input.Add(num2);
            model.input.Add(num3);
            model.input.Add(num4);
            model.input.Add(num5);


            return View(model);
        }

        //GET: Last Two
        public ActionResult LastTwo()
        {
            return View();
        }

        //GET: Last Two Result
        public ActionResult LastTwoResult(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10)
        {
            List<string> model = new List<string>();
            model.Add(word1);
            model.Add(word2);
            model.Add(word3);
            model.Add(word4);
            model.Add(word5);
            model.Add(word6);
            model.Add(word7);
            model.Add(word8);
            model.Add(word9);
            model.Add(word10);

            return View(model);
        }

        //GET: Baby Lotto
        public ActionResult BabyLotto()
        {
            return View();
        }

        //GET: Baby Lotto Results
        public ActionResult BabyLottoResult(string ticket1, string ticket2, string ticket3, string ticket4, string ticket5)
        {
            Converter<string, int> converter = new Converter<string, int>(int.Parse);
            List<Ticket> model = new List<Ticket>();

            model.Add(new Ticket(Array.ConvertAll(ticket1.Split(','), converter)));
            model.Add(new Ticket(Array.ConvertAll(ticket2.Split(','), converter)));
            model.Add(new Ticket(Array.ConvertAll(ticket3.Split(','), converter)));
            model.Add(new Ticket(Array.ConvertAll(ticket4.Split(','), converter)));
            model.Add(new Ticket(Array.ConvertAll(ticket5.Split(','), converter)));

            return View(model);
        }

        //GET: Squirrel Party
        public ActionResult SquirrelParty()
        {
            return View();
        }

        //GET: Squirrel Party Results
        public ActionResult SquirrelPartyResult(int numSquirrels, string isWeekend )
        {
            bool isSuccess = false;
           

            if(isWeekend != null && numSquirrels >= 40)
            {
                isSuccess = true;
            }
            else if(numSquirrels >=40 && numSquirrels <= 60)
            {
                isSuccess = true;
            }
            return View(isSuccess);
        }



    }
}