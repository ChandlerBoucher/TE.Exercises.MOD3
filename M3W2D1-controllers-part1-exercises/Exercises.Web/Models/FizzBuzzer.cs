using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class FizzBuzzer
    {
        public string fizzer { get; set; }
        public string buzzer { get; set; }
        public int div1 { get; set; }
        public int div2 { get; set; }
        public List<int> input { get; set; }

        public FizzBuzzer()
        {
            input = new List<int>();
            fizzer = "Fizz";
            buzzer = "Buzz";
            div1 = 3;
            div2 = 5;
        }
    }
}