using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VarPrim
{
    class ShubhayVar
    {
        static void Main(string[] args)
        {
            /// Declares a variable and prompts user to type in number 
            string anotherval; 
            /// Declares data types used in out later in the if and else if statements
            sbyte rese;
            byte resolution;
            short middleone;
            ushort type_;
            int hellobro;
            uint soarer;
            long longtype;
            ulong uversionlong;
            float floattype;
            double doubletype;
            decimal decimaltype;

            /// Gives back the result 
            /// This program leaves out object and string (both null), bool and char (t/f and character)

            do
            {
                Console.WriteLine("Enter a number!! - ");
                var val = Console.ReadLine();

                if (SByte.TryParse(val, out rese))
                {
                    Console.WriteLine("This means that your number, " + val + " is a SByte!");
                }
                else if (Byte.TryParse(val, out resolution))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Byte!");
                }
                else if (short.TryParse(val, out middleone))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Short!");
                }
                else if (ushort.TryParse(val, out type_))
                {
                    Console.WriteLine("This means that your number, " + val + " is a UShort!");
                }
                else if (int.TryParse(val, out hellobro))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Int!");
                }
                else if (uint.TryParse(val, out soarer))
                {
                    Console.WriteLine("This means that your number, " + val + " is a UInt!");
                }
                else if (long.TryParse(val, out longtype))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Long!");
                }
                else if (ulong.TryParse(val, out uversionlong))
                {
                    Console.WriteLine("This means that your number, " + val + " is a ULong!");
                }
                else if (float.TryParse(val, out floattype))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Float!");
                }
                else if (double.TryParse(val, out doubletype))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Double!");
                }
                else if (decimal.TryParse(val, out decimaltype))
                {
                    Console.WriteLine("This means that your number, " + val + " is a Decimal!");
                }

                Console.WriteLine("Do you want to run the program again? Yes or no?");
                anotherval = Console.ReadLine();

            } while (anotherval != "no");

            Console.WriteLine("Good Bye.");

            /// End of program 
        }
    }
}
