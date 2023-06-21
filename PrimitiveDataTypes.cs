using System;

class Program
{

    static int iAmANumber = 10; // static modifier is mandatory outside of the Main funtion [-2,147,483,648;-2,147,483,647]
    static int DefaultValue; // default value assigned = 0

    static void Main(string[] args)
    {
        iAmANumber = 5;
        float pi = 3.1415f; // [1,5 * 10^-45 ; 3.4 * 10 ^ 38] -> 7 digit precision
        double db = 1.5; // 15 digit precision
        decimal dec = 1.5m; // 28 digit precision
        bool isGPSEnabled = true;
        string Name = "Denis";
        char at = '@';
        byte b = 120; // [0 ; 255]
        sbyte x = -120; // Signed Byte [-128 ; 127]
        short y = 30000; // [-32767 ; 32767]
        long z = 900000000000000; // [-9,223,327,036,854,775,808 ; 9,223,327,036,854,775,807]


        int num1;
        num1 = 13;
        Console.WriteLine(num1);
        int num2 = 23;
        int sum = num1 + num2;
        Console.WriteLine(sum);
        Console.WriteLine("num1 is " + num1);
        
        int num3, num4, num5;
        num2 = 100;
        Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);
        
        double d1 = 3.1415;
        double d2 = 5.1;
        double dDiv = d1 / d2;
        Console.WriteLine("d1/d2 is " + dDiv);

        float f1 = 3.1415f; // on default considered as a double -> f 
        float f2 = 5.1f;
        float fDiv = f1 / f2;
        Console.WriteLine("f1/f2 is " + fDiv);


        long myLongNum = 18121211212121212;
        Console.WriteLine(myLongNum);

        double dIDiv = d1 / num1;
        // int dIDivInt = d1 / num1;

        Console.WriteLine("d1/num1 is " + dIDiv);

        Console.Read();
    }
}