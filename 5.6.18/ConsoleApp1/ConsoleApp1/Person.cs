using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate string SignatureHandler(string param);
    class Person

    {
        public event SignatureHandler PersonSignature;

        public string FullName { get; set; }
        public bool WantToSign { get; set; }


        public string SignAction(string param)
        {
            
            if (WantToSign == true)
            {
                if (PersonSignature != null)
                {
                    return PersonSignature(param);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
