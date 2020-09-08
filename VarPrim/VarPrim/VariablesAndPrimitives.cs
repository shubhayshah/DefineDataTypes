using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is a basic program explaining datatypes 
// Hint, hint -- talking about the byte type

namespace VarPrim
{
    class VariablesAndPrimitives
    {
        static void Main2(string[] args)
        {
            // There are many different types of [integer] types such as
            /// sbyte , Def. Value is 0, whereas min. value is -128 and max. value is 127


            /// byte, Def. and Min. Values are 0; Max. Value is 255
            sbyte MurrowNull = 5;
            byte ByteDataType = 10;
            int IntegerTypeOne = 126;
            var TestForFunction = 162; 



            /// Writes out 'This is a byte function' on the console 
            Console.WriteLine("These are all data types, right? The sbyte value is " + MurrowNull + " and ByteDataType's value is " + ByteDataType);
            Console.WriteLine("Integers are the most popular data type. The value is " + IntegerTypeOne);
            Console.WriteLine("Variables are the last topic for today! The value is " + TestForFunction + " !");

            /// This prints out the maximum value of the 64-bit Int data type 
            /// The value is 18446744073709551615

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine("The value of the 64-bit Int is " + maxIntValue);

        }
    }
}


/* The byte type specifies the set of integers in the range of 0 to 255. 
 The byte type is mainly used for memory and storage, as the byte type is
considered as a Data Type */


