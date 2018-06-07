using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///set a defult value to init the arrys later////
            int NumOfPepole = 7;
            
            //////////////create the arrys 
            Person[] PersonArr = new Person[NumOfPepole];
            Signature[] signatureArr = new Signature[NumOfPepole];

            ///////init the person arr/////////////////
            for (int i = 0; i < PersonArr.Length ; i++)
            {
                PersonArr[i] = new Person();
            }

            ///////////////init each person name,want to sign and signature/////////

            PersonArr[0].FullName = "Bob Arnold";
            PersonArr[0].WantToSign = true;
            PersonArr[0].PersonSignature += (string param) =>
              {
                  return param.ToLower();
              };
            /////////////////////////////////////////////////
            PersonArr[1].FullName = "Alice Avery";
            PersonArr[1].WantToSign = true;
            PersonArr[1].PersonSignature += (string param) =>
            {
                string[] name = param.Split(' ');
                return name[0] + name[1];

            };
            ///////////////////////////////////////////////////
            PersonArr[2].FullName = "Albert Bailey";
            PersonArr[2].WantToSign = true;
            PersonArr[2].PersonSignature += (string param) =>
            {
                string [] name = param.Split(' ');
                string firstname = name[0];
                string lastname = name[1];
                string firstLetter = Convert.ToString(firstname[0]);
                string LastLetter = Convert.ToString(lastname[0]);
                return firstLetter+LastLetter;
                };

            ///////////////////////////////////////////////////
            PersonArr[3].FullName = "Matt Baker";
            PersonArr[3].WantToSign = false;
            PersonArr[3].PersonSignature += (string param) =>
            {
                string[] name = param.Split(' ');
                string firstname = name[0];
                char firstLetter = firstname[0];
                return Convert.ToString(firstLetter + name[1]);

            };
            ///////////////////////////////////////////////////
            PersonArr[4].FullName = "Carol Cambell";
            PersonArr[4].WantToSign = true;
            PersonArr[4].PersonSignature += (string param) =>
            {
                return param.ToUpper();
            };
            ///////////////////////////////////////////////////
            PersonArr[5].FullName = "Kavin Brown";
            PersonArr[5].WantToSign = false;
            PersonArr[5].PersonSignature += (string param) =>
            {
                string[] name = param.Split(' ');
                return (name[0] + "." + name[1]);
            };
            ///////////////////////////////////////////////////
            PersonArr[6].FullName = "Lisa Bower";
            PersonArr[6].WantToSign = true;
            PersonArr[6].PersonSignature += (string param) =>
            {
                string[] name = param.Split(' ');
                return name[0].ToLower();
            };


            ////////////////////////////////////////////////////////
            
            
            //////////////////init the siganture arr //////////////////////
            for (int i = 0; i < PersonArr.Length; i++)
            {
                signatureArr[i]=new Signature(PersonArr[i].FullName,PersonArr[i].SignAction(PersonArr[i].FullName));

            }

            //////////////print the signature arr on the console screen///////////////////
            foreach (Signature item in signatureArr)
            {
                Console.WriteLine($"person name: {item.FullName}");

                if (item.FullSignature == null)
                {
                    Console.WriteLine("I dont want to sign");
                }
                else {
                    Console.WriteLine($"person signature: {item.FullSignature}");
                }
                Console.WriteLine("------------------------------------------");

            }
            






        }
    }
}
