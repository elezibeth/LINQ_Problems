using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25

        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        public static List<string> RunProblem1(List<string> words)
        {
            List<string> thWords = new List<string>();

            //code
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            // input into method
            // 2. Query creation.
            // problem 1 is an IEnumerable<string>

            var wordsWithTh =
                from string w in words
                where w.Contains("th")
                select w;
            //3.  Query execution
            thWords = wordsWithTh.ToList();
            
                //return

            
            return thWords;
        }

        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            //input into method;
            List<string> noDuplicateNames = new List<string>();
            // 2. Query creation.
            


            var nameQuery2 =
                from n in names
                group n by names into nNames
                where nNames.Count() > 0
                orderby nNames.Key
                select nNames.Key[0];
        

            // 3. Query execution.
            noDuplicateNames = nameQuery2.ToList();
            return noDuplicateNames;
        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {

            //customers.AsQueryable();
            //code
            var mikeQuery =
               (from c in customers
                where c.FirstName.Contains("Mike")
                select c).First();

           
            //return
            return mikeQuery;

        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers)
        {
            //code
            var idQuery3 =
              (from c in customers
               where c.Id == 3
               select c).First();

            idQuery3.FirstName = "Jack";
            idQuery3.LastName = "Sprat";
            //return
            return idQuery3;

        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {

            //code
            List<double> dGrades = new List<double>();
            for(int i = 0; i <= classGrades.Count - 1; i++)
            {
                //-separate strings into separate lists.
                string extractedString = ExtractNextString(classGrades, i);
                //-convert each grade to own string AND add to own list
                var induvidualGrades = GetIntArrayAsList(extractedString);
                //-drop lowest grade in each list
                //-get average grade from each list
                //-return double average grade
                var averageGrade = GetAverageGrade(induvidualGrades);
                //-add returned double to list
                dGrades.Add(averageGrade);
            }

            //-average averages grades from lists
            var avgTotal = dGrades.Average();
            //-return average grade


            //return
            return avgTotal;
        }
        public static string ExtractNextString(List<string> classGrades, int index)
        {
            string stringToSeparate= classGrades[index];
            
            return stringToSeparate;
           
           
        }
        public static List<double> GetIntArrayAsList(string extractedString)
        {
            //code
            
            //var nums = extractedString;
            var indGd = extractedString.Split(',').Select(r => Convert.ToDouble(r)).ToArray();
            List<double> list = indGd.ToList();
            //return
            return list ;
        }
        public static double GetAverageGrade(List<double> list)
        {
            var lowest =
                list.Min();
            list.Remove(lowest);
            var avg = list.Average();
            return avg;
        }
        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1")
        //public static string RunBonusProblem1(string word)
        //{
        //    var word2 = new char[word.Length];
        //    //code
        //    var charFreq = 
        //        from x in word2
        //        where x =

               
               
        //    //return
        //    return word3;

        //}
        #endregion
    }
}
