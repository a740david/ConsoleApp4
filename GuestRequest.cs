using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class GuestRequest
    {
        public DateTime  EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsApproved { get; set; }
      
        public override string ToString()
        {
            string str = "";
            str += string.Format("EntryDate: {0}", EntryDate, "ReleaseDate:{1}", ReleaseDate, "IsApproved: {2}", IsApproved);
            return str;
        }
    }
}
