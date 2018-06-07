using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Signature
    {
        public string FullName { get; set; }
        public string FullSignature { get; set; }


        public Signature(string FullnameParam,string FullSignatureparam)
        {
            FullName = FullnameParam;
            FullSignature = FullSignatureparam;
        }
    }

}
