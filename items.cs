using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Seession3_
{
    public class itemsss
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Priority { get; set; }


        public void display()
        {
            Console.WriteLine($"titlel:{Title}");
            Console.WriteLine($"descrapitio:{Description}");
            Console.WriteLine($"date:{Date}");
            Console.WriteLine($"priority:{Priority}");
            Console.WriteLine("**************************");
        }
    }
}
