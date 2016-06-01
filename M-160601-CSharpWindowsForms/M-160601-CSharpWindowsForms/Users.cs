using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_160601_CSharpWindowsForms
{
    public class Users
    {
        public Users(int index)
        {
            Index = index;
        }
        public int Index { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + SurName;
        }
    }
}
