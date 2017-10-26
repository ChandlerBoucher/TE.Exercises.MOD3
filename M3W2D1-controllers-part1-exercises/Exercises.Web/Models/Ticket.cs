using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class Ticket
    {
       public int[] nums { get; set; }

        public Ticket()
        {
            Random myRand = new Random();
            nums = new int[3];
            nums[0]= myRand.Next(1, 999);
            nums[1]= myRand.Next(1, 999);
            nums[2]= myRand.Next(1, 999);
        }
        public Ticket(int[] numm)
        {
            nums = new int[3];
            
            nums[0] = numm[0];
            nums[1] = numm[1];
            nums[2] = numm[2];
            
        }
    }
}