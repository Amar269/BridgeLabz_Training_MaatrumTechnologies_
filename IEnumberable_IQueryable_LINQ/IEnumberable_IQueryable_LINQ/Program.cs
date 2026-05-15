using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace LINQDemo
{
    class newcodes

    {
        static void Main(string[] args)
        {
            List<Students> std = new List<Students>()
            {
                new Students(){Id = 1,Name = "Amar" , Age = 20},
                new Students(){Id = 2,Name = "nath" , Age = 23},
                new Students(){Id = 3,Name = "kolla" , Age = 22},

            };

            // IEnumerable.
            IEnumerable<Students> stds = from sttd in std
                                         where sttd.Age >= 21
                                         select sttd;



            // IQUERYABLE.
            // IQueryable<students> stds = sttd.ASQueryable().Where(std => std.Age>= 21);

            foreach (var item in stds)
            {
                Console.WriteLine($"id : {item.Id} , Name : {item.Name}");
            }

        }
    }
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}