using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToonPenen_Interfaces1.Models;

namespace ToonPenen_Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction_1 = new Transaction("0001", "31/12/2020", 50);            
            transaction_1.ShowTransaction();
            Console.WriteLine(new string('-', 50));
            
            Transaction transaction_2 = new Transaction("0001", "31/12/2020", 376);
            transaction_2.ShowTransaction();
            Console.WriteLine(new string('-', 50));

        }
    }
}
