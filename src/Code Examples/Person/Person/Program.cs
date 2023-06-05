// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

public class Progra
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test");
        Console.WriteLine("Hi I am Md Raufur Rahim");
        Console.Write("Maruf");
        Console.WriteLine(" Khan");
        /* string z = Console.ReadLine();
         string[] x = z.Split(',');
         Console.WriteLine("Name{0}\n Age: {1}", x[0], x[1]);
         Console.WriteLine($"Name: {x[0]} \n Age: {x[1]}\n CGPA: {x[2]}");
         foreach(string s in x)
             Console.WriteLine(s);
         int x2 = 3;
         int y = 9;
         x2 = ~x2;
         Console.WriteLine(++x2);
         bool statement = x2 > 4 && y < 10;
         if(statement)
         {
             Console.WriteLine("Successful");
         }
         if(x2>4 || y<10 )
         {
             Console.WriteLine("Success");
         }
         int x3 = x2 << 2;
         Console.WriteLine("X3 After left shift"+x3);*/
        uint t = 5;
        Console.WriteLine(~t);
        string name = Console.ReadLine();
        name = name.Length > 10 ? name.Substring(0,10) : name;
        Console.WriteLine(name);
    }
}
/*0=0
1=1
2=10
3=11
4=100
5=101
00011
00110
01100
2^3+2^5
*/