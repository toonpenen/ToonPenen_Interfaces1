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
            Transaction transaction_1 = new Transaction("0001", "20/12/2020", 50);            
            transaction_1.ShowTransaction();
            transaction_1.GetAmount();


                Console.WriteLine("---------");
            
            Transaction transaction_2 = new Transaction("0001", "31/12/2020", 376);
            transaction_2.ShowTransaction();
            transaction_2.GetAmount();


                Console.WriteLine("---------------");

        }
    }
}
