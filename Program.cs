using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /////// byte b = 1; // A byte is one byte and an int (integer) is four bytes///////
            //int i = 1;
            //byte b = 1;
            //Console.WriteLine(i);


            /////// Assigning an int value to an int variable/////////
            ///// Attempting to assign the int value to a byte variable
            //  This will result in a compilation error or data loss if not handled properly
            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("THE NUMBER COULD NOT BE CONVERTED TO A BYTE.");
            }

        }
    }
}
