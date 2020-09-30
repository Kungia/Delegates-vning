using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesövning
{

    class Program
    {
       public delegate void IntDelegate(int number);
        static void Main(string[] args)
        {
            //UPPGIFT 1
            //Skapa en klass som representerar ett valfritt djur. Det ska ha minst två events som motsvarar saker som djuret gör.
            //Skriv metoder i klassen som anropar dina events vid rätt omständigheter.
            //Testa genom att prenumerera på dina events med funktioner som skriver ut saker på konsolen.
            Tortoise Håkan = new Tortoise();
            Håkan.Chomp += OnChomp;
            Håkan.Crawl += OnCrawl;

            Console.WriteLine(Håkan.DoChomp()); 
            Console.WriteLine(Håkan.DoCrawl());
            Console.ReadKey();

            static void OnChomp() //prenumererar på mitt event Chomp
            {
                Console.WriteLine("The Tortoise is Eating.");
            }

            static void OnCrawl() //prenumererar på mitt event Crawl
            {
                Console.WriteLine("The tortoise crawls away slowly");
            }
            
            //UPPGIFT 2
            //Skapa en klass som kan skriva ut saker på konsolen. 
            //Den ska ha ett event för händelsen att något skrivs ut.
            //Skapa en ny klass, som prenumererar på utskriftshändelsen.
            PrintingPress Printer = new PrintingPress();
            Reader Reader = new Reader(); 

            Printer.Print += Reader.OnPrinting;
            Printer.Printing("Printing press: Hey, listen up!");
            Console.ReadKey();
            //UPPGIFT 3
            //Skapa en funktion med namnet UsesCallback som tar en Action-delegate som parameter. 
            //Det ska vara en icke - generisk Action - delegate, alltså en som kan peka på en funktion som inte tar några parametrar och inte returnerar något värde.
            //Funktionen UsesCallback ska som det sista den gör anropa funktionen som din Action - delegate pekar på. 
            //Testa genom att göra en ny funktion som skriver ut ett meddelande på konsolen och anropa UsesCallback med den nya funktionen som parameter.

            UsesCallback(OnChomp);
            Console.ReadKey();

            static void UsesCallback (Action callback)
            {
                callback(); 
                Console.WriteLine("The tortoise will now sleep");
            }
            //UPPGIFT 4 
            //Skapa en funktion som skriver ut alla element i en collection av typen int. 
            //Funktionen ska ta tre parametrar: listan som ska skrivas ut och två delegates med namnen even respektive odd. 
            //Det ska vara samma delegate, en som tar en parameter av datatypen int.
            //Din funktion ska loopa igenom hela collection och skriva ut varje element med en delegate av dina två delegates så att de används varannan gång.

            IntCollection(
                         new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                         (number) => { Console.WriteLine("this is a very even number; " + number); },
                         (number) => { Console.WriteLine("this is a very odd number; " + number); }
                         );
            Console.ReadKey();
            
           
            
            static void IntCollection (List<int> IntList, IntDelegate even, IntDelegate odd);
            {
                foreach (int number in IntList)
                {
                    if (number % 2 == 0) {even(number); }
                    else if (number % 2 != 0) {odd(number); }
                }
            }

        }
    }
}
