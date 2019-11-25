using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class GuestRe
    {
        private int EntryDate, ReleaseDate;
        bool IsApproved;
        public int X
        {
            get { return EntryDate; }
            set { EntryDate = value; }
        }
        public int y
        {
            get { return ReleaseDate; }
            set {ReleaseDate = value; }
        }
        public bool z
        {
            get { return IsApproved; }
            set { IsApproved=value; }
        }
        public override string ToString()
        {
            string str="";
            str += string.Format("EntryDate: {0}", EntryDate, "ReleaseDate:{1}", ReleaseDate);
            return str;

        }
}
