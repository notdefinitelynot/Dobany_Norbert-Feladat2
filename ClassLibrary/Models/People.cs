using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class People
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Occupation { get; set; }
        public string Hobbies { get; set; }
        

        public People()
        {
        }

        public People(string sor)
        {
            string[] t = sor.Split(';');
            Name = t[0];
            Age = Convert.ToInt32(t[1]);
            Country = t[2];
            Occupation = t[3];
            Hobbies = t[4];
        }

        public override string? ToString()
        {
            return $"Név: {Name}, Életkor: {Age}, Ország: {Country}, Foglalkozás: {Occupation}, Hobbik: {Hobbies}";
        }
    }
}

