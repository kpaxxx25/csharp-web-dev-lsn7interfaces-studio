using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : DiscMaster, IOpticalDiscs
    {
        public void PlayMusic()
        {
            Console.WriteLine(true);
        }
        public CD(string name, List<string> contents, string discType) : base(name, contents, discType)
        {

        }
        public void SpinDisc()
        {
            Console.WriteLine("500 rpm");
        }
        public void RewindDisc()
        {
            Console.WriteLine("Backwards");
        }
        public void WriteDisc()
        {
            Console.WriteLine("mixed tap for my pals");
        }
    }
}

//// TODO: Implement your custom interface.

// TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
//  need to be declared separately. 
