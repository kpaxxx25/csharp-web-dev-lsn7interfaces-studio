using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class DiscMaster
    {
        string Name { get; set; }
        List<string> Contents { get; set; }
        string DiscType { get; set; }

        public DiscMaster(string name, List<string> contents, string discType){
            Name = name;
            Contents = contents;
            DiscType = discType;
       }

    }
}
