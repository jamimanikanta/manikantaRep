using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplecsharp
{
   public  class Program
    {
        public  string  names { get; set; }
        public string city { get; set; }
        public static void Main(string[] args)
        {
            string number = "10";
            int value;
            value = Convert.ToInt32(number);
            Console.WriteLine(value);
            Console.Read();

        }
    }
}
