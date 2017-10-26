using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class Name
    {
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public List<string> colors { get; set; }
        public int order { get; set; }
    }
}