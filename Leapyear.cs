using System;
using System.IO;
class Leapyear{

public static void Main(String[] args)
{

Leapyear LP =new Leapyear();
int num = 0, year =0;
num = Convert.ToInt32(Console.ReadLine());
//year = num/366;
//year = num/4;
Console.WriteLine(year);
if(year == num%4 && year != num%100)
{
Console.WriteLine("LEAP YEAR");
}
else {
Console.WriteLine("Not LEAP YEAR");
}
}

}
