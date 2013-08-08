using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Person
    {
        public string FullName { get; set; }
        public string StreetNo { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string PhoneNo { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6:c}", FullName, StreetNo, Address, State, PostCode, PhoneNo, Salary);
        }
    }
}
