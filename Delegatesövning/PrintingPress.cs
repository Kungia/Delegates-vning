using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesövning
{
    internal class PrintingPress
    {
        public event Action Print; //event för händelsen att något printas på konsollen

        public PrintingPress()
        {
        }
        public void Printing(string print)
        {
            Console.WriteLine("Printing Press: blippetyblopp, printing the news, just like you do!");
            Console.ReadKey();
            Console.WriteLine(print);
            Print();
        }

    }
}
