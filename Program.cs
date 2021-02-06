using System;
using static System.Console;
//Stephanie Friddle
//2.7.21
//Midterm comprehensive project
//References: Farrell, J. (2018). Microsoft Visual C# 2017: An Introduction to Object-Oriented Programming, Seventh Edition. Mexico: Cengage.
// https://www.youtube.com/watch?v=GhQdlIFylQ8&t=13338s

namespace DemoJobs
{
    class Jobs
    {
        public double total;
        private string description;
        private double duration;
        private double fee;
        public double Duration { get; set; }
        public double Fee { get; set; }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                //change these to the real descriptions
                if (value == "description" || value == "description" || value == "description")
                    description = value;
                else
                    WriteLine("I'm sorry, Harold's Home Service currently does not offer that service.");
            }
        }

     //   public double Total
     //   {
     //      get
     //       {
     //           return total;
     //       }
     //       set
     //       {
     //           total = duration * fee;
     //       }
     //   }

        public Jobs(string jobDescription, double jobDuration, double jobFee, double jobTotal)
        {
            description = jobDescription;
            duration = jobDuration;
            fee = jobFee;
            total = jobTotal;
        }

        static void Main(string[] args)
        {

            ReadLine();
        }
    }
}
