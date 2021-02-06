using System;
using static System.Console;
//Stephanie Friddle
//2.7.21
//Midterm comprehensive project
//References: Farrell, J. (2018). Microsoft Visual C# 2017: An Introduction to Object-Oriented Programming, Seventh Edition. Mexico: Cengage.
// https://www.youtube.com/watch?v=GhQdlIFylQ8&t=13338s

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Jobs job1 = new Jobs("Carpet Cleaning Package", 4, 100);
            Jobs job2 = new Jobs("Washing Windows Package", 2.5m, 50);
            Jobs job3 = new Jobs("Lawn Care Package", 3, 75);
            Jobs job4 = new Jobs("House Cleaning Package", 2, 60);
        }
    }
    class Jobs
    {
        public string Description { get; set; }
        public decimal Duration { get; set; }
        public decimal Fee { get; set; }
        public decimal Total
        {
            get { return Duration * Fee; }
        }
        public Jobs(string jobDescription, decimal jobDuration, decimal jobFee)
        {
            Description = jobDescription;
            Duration = jobDuration;
            Fee = jobFee;
        }
        public static Jobs operator+(Jobs job1, Jobs job2)
        {
            Jobs multiJob = new Jobs(job1.Description + " and " + job2.Description,
                job1.Duration + job2.Duration,
                (job1.Fee + job2.Fee) / 2);
            return multiJob;
        }
    }
}
