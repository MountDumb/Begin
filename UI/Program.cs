using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;



namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new IntroToEfContext())
            {
                foreach (var item in db.Pet_Breed)
                {
                    Console.WriteLine(item.BreedName);
                }
            }
            Console.ReadKey();
        }
    }
}
