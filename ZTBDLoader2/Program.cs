using System;
using System.Linq;

namespace ZTBDLoader2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new mubi_dbContext();
            var res = context.Ratings.Count();
            for (int i = 0; i < res; i= i+5)
            {
                var rating = 
            }

            Console.WriteLine("sdadsa");
            
            


        }
    }
}
