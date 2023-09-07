using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10; //value type
            object boxedNum = num; //implicit conversion from value to ref
            int unboxedNum = (int)boxedNum; //explicit conversion from ref to value
          
            Console.WriteLine("Original number (integer) is:" +num);
            Console.WriteLine("Boxed number (object) is: "+boxedNum); 
            Console.WriteLine("Unboxed number (integer) is: "+unboxedNum);
           
            //Used for methods where a specific type is only accepted hence the need for conversion
        }
    }
}
