// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int x = 5;
Console.WriteLine(x);
string t = "Maruf khan";
Console.WriteLine(t);
DateTime dt = DateTime.Now;
Console.WriteLine(dt);
DateOnly dateOnly = new DateOnly();
Console.WriteLine(dateOnly); */
using System.Data.Common;

int x = 5;
string name = "Maruf khan";
double[] age =new double[5];
age[0] = 2.3;
age[1] = 4.64;
age[2] = 5.6;
age[3] = 6.7;
age[4] = 8.9;

double myage= age[0];
int[,] x1 =
{
    {
        2,2
    },
    {
    4,4
    }
};
for(int i=0;i<2;i++)
{
    for (int j=0;j<2;j++)
    {
        Console.Write(x1[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();

}
Console.WriteLine("Another Way of Array declaration");
int[,] x2 = new int[4, 2]
{
    {1,1},
    {2,2},
    {4,4},
    {5,5}
};
for(int i = 0;i<x2.GetLength(0);i++)
{
    for(int j=0;j<x2.GetLength(1);j++)
    {
        Console.Write(x2[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

int[,] x3 = new int[3, 4]
{
    { 2, 2, 2, 2 },
    { 4, 4, 4, 4 },
    { 6, 6, 6, 6 }
};
Console.WriteLine("Practicing");
for(int i=0;i<x3.GetLength(0);i++)
{
    for(int j=0;j<x3.GetLength(1);j++)
    {
        Console.Write(x3[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Printing using While loop");
int row = 0;
int col = 0;
while (row < x3.GetLength(0))
{
    
        Console.Write(x3[row, col]);
        Console.Write(" ");
        
        col++;
    if (col >= x3.GetLength(1))
    {
        col = 0;
        row++;
        Console.WriteLine();
    }
    
}
int[][,] jaggedArray = new int[4][,];
jaggedArray[0] = x1;
jaggedArray[1] = x2;
jaggedArray[2] = x2;
jaggedArray[3] =x1;
for (int n = 0; n < jaggedArray.Length; n++)
{
    for(int i=0;i<x1.GetLength(0);i++)
    {
        for(int j=0;j<x1.GetLength(1);j++)
        {
            Console.WriteLine("ki");
        }
    }
}
