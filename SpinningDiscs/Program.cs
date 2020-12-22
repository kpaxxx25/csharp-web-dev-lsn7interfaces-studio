using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> 
            
                movieList = new List<string>
            {
                "Scenes",
                "Bloopers"
            };

            DVD shrek = new DVD("shrek", movieList, "dvd");
            shrek.SpinDisc();
            
        }
    }
}

// TODO: Declare and initialize a CD and a DVD object.

// TODO: Call each CD and DVD method to verify that they work as expected.
