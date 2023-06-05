// See https://aka.ms/new-console-template for more information
using System.Transactions;

/*int x = 5;
string name = "Md Raufur Rahim";
double[] ages = new double[5];
ages[0] = 67.6;
double myage = ages[0];
double friends = 500.5;
float f2 = 3.4f;
double[] ages2 = new double[] { 0, 5.5, 6.7, 8.8};
double[] ages3 = { 3.5, 56.6, 543.4, 45.4,friends,f2 };
Console.WriteLine(ages3[4]);
for(int i=0;i<ages3.Length;i++)
{
    Console.WriteLine(ages3[i]);
}*/

double x1 = 5.5;
float x2 = 4.7f;
double[] x3= new double [] { x1, x2,};
for (int i = 0; i < x3.Length; i++)
{
   // Console.WriteLine(x3[i]);
}

double[,] p1 = new double[3, 2];
p1[0, 0] = 5.4;
p1[0, 1] = 6.2;
p1[1, 0] = 5.23;
p1[1, 1] = 7.7;
p1[2, 0] = 9.9;
p1[2, 1] = 9.22;
for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(p1[i, j]);
        Console.Write("   ");
    }
    Console.WriteLine();
        }
