using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class RegexExample
    {
        static string pattern = "^cen$";
        //^it will indicate string start
        //$it will indicate the end of the string

        public void MyRegex()
        {
            //we have created object of class
            //we have given a pattern in given class constuctor
            Regex regex = new Regex(pattern);

            //ismatch return true if its matches the string otherwise it return false.
            if (regex.IsMatch(""))
            {
                Console.WriteLine("string is match the pattern");
            }
            else
            {
                Console.WriteLine("string is not  match the pattern");

            }


        }
        public void CheckName(string name)

        {
            string myName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(myName, name))
            {
                Console.WriteLine("string is match the pattern");
            }
            else
            {
                Console.WriteLine("string is not  match the pattern");

            }
        }
        public void LastName(string name)

        {
            string myLastName = "^[A-Z][a-z]{3,}?$";
            if (Regex.IsMatch(myLastName, name))
            {
                Console.WriteLine("string is match the pattern");
            }
            else
            {
                Console.WriteLine("string is not  match the pattern");

            }
        }
    }


}
