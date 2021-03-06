using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsWithTh = LinqProblems.RunProblem1(words);
            foreach(string word in wordsWithTh)
            {
                Console.WriteLine($"problem 1 {word}");
            }
           
                
            //(5 points) Problem 1
            //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
            //List<string> stringList = new List<string>();

            //public static List<string> RunProblem1(List<string> words)
            //{
            //    //code

            //    //return

            //}

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> noDuplicateNames = LinqProblems.RunProblem2(names);
            foreach (string i in noDuplicateNames)
            {
                Console.WriteLine($"problem 2 {i}");
            }
            



            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };
            //problem 3
            Customer returnedCustomer = LinqProblems.RunProblem3(customers);
            Console.WriteLine($"problem 3 = {returnedCustomer.FirstName}");
            //problem 4
            Customer returnedCustomer2 = LinqProblems.RunProblem4(customers);
            Console.WriteLine($"Problem 4 {returnedCustomer2.FirstName} {returnedCustomer2.LastName}");




            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            double average = LinqProblems.RunProblem5(classGrades);
            Console.WriteLine($"problem 5: {average}");



            ////--------------------
            ////Bonus Problem 1
            //string letters = "terrill";
            //string letters2 = LinqProblems.RunBonusProblem1(letters);
            //Console.WriteLine($"problem bonus1; {letters2}");
            Console.ReadLine();

        }
    }
}
