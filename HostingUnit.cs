using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class HostingUnit:IComparable
    {
        private static int stSerialKey = 10000000;
        public int HostingUnitKey { get; private set; }
        private bool[,] Diary;
        public HostingUnit()
        {
            Diary = new bool[12, 31];
            HostingUnitKey = stSerialKey;
            stSerialKey++;
        }
       
        
        public int CompareTo(object obj)
        {
            return t
        }
    }
}
