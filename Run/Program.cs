using ClassLibrary.Models;
using ClassLibrary.Data;
using System;

namespace Run
{
    public class Program
    {

        static void KiIr(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Context db = new Context();
            if (!db.People.Any())
            {
                var sorok = File.ReadAllLines(@"C:\\Users\\Diak\\Downloads\\22.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.People.Add(new People(line));

                }
                db.SaveChanges();
            }

            KiIr(db.People);
        }
    }
}
