using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesövning
{
    internal class Reader
    {
        internal void OnPrinting()
        {
            Console.ReadKey();
            Console.WriteLine("Reader: schh, I am reading the news you wrote!");
        }
         
    }
}
