using System;
using System.Collections.Generic;
using System.Text;

namespace Delegatesövning
{
    internal class Tortoise
    {
        public event Action Chomp;
        public event Action Crawl;
        public Tortoise()
        {
        }
        public string DoChomp() //event 1
        {
            Chomp(); 
            return "Chompachompa.... Delicious";           
        }
        public string DoCrawl() //event 2
        {
            Crawl(); 
            return"Thump,thump,thump";  
        }
    }
}
