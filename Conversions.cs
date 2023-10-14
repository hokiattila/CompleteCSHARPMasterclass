using System;

namespace conversions 
{
    class Conversions
    {
        static void Main(string[] args)
        {
            double MyDouble = 13.37;
            int MyInt;

            // cast to int -> explicit conversion
            MyInt = (int) MyDouble;
            Console.WriteLine(MyInt);

            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float MyFloat = 13.37F;
            double myNewDouble = MyFloat;


            // type conversion 
            string MyString = MyDouble.ToString();
            Console.WriteLine(MyString);
            string MyFloatString = MyFloat.ToString();
            Console.WriteLine(MyFloatString);
            

            bool SunIsShining = false;
            string SunIsShiningString = SunIsShining.ToString();
            Console.WriteLine(SunIsShiningString);
            

            Console.Read();
        }
    }
}