using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            if (input == null) // if input is null
            {
                return null; 
            }

            string ans = "";
            string len = (input.Length).ToString();
            string[] ssize = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string wcount = (ssize.Length).ToString(); 
            ans = len + "," + wcount + ":" + input; 
            return ans;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string input = Console.ReadLine();
            Program p = new Program();
            Console.WriteLine(p.Prefix("Hello World"));
        }

        
    }
}
