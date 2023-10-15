using System;

enum Day {Mo, Tu, We, Th, Fr, Sa, Su};
enum Mont {Jan=1, Feb, Mar, Apr, May, Jun, Jul=12, Aug, Sep, Oct, Nov, Dec }

class Enums
{
    static void Main(string[] args) 
    {
            Day fr = Day.Fr; // also indexed 0 -> 6 
            Day su = Day.Su;
            

            Day a = Day.Fr;
            
            Console.WriteLine(a == fr);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int) Day.Mo);
            

            Console.WriteLine((int) Mont.Feb);
            Console.WriteLine((int) Mont.Jul);
            Console.WriteLine((int) Mont.Aug);

            

            Console.ReadKey();
    }
}