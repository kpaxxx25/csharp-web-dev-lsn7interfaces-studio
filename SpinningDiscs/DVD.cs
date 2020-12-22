using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : DiscMaster, IOpticalDiscs
    {
       public void PlayMovies()
        {
            Console.WriteLine(true);
        }
        public DVD(string name, List<string> contents, string discType) : base(name, contents, discType)
        {

        }
        public void SpinDisc()
        {
            Console.WriteLine("570-1600 rpm");
        }
        public void RewindDisc()
        {
            Console.WriteLine("Backwards");
        }
        public void WriteDisc()
        {
            Console.WriteLine("This is Shrek bought from Movie Man.");
        }

    }
}


// TODO: Implement your custom interface.

// TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
//  need to be declared separately.