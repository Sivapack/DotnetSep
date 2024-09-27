using System;
class Statvarr{

public static int i;
public static void display()
{
  i =10;
/*Console.WriteLine(i);*/
Console.WriteLine(i);
}

public void add()
{
int j =15;
Console.WriteLine(j);

}
public static void Main(string[] args)
{

Statvarr objstat = new Statvarr();
Statvarr.display();
objstat.add();
Console.Read();

}

}