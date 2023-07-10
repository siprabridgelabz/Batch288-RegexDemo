using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        
        static void Main(string[] args)
        {
          
            RegexExample regexExample = new RegexExample();
           // regexExample.MyRegex();
            regexExample.CheckName("");
            Console.ReadLine();
        }
    }
}
