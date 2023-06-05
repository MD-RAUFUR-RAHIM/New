int[][,] jaggedArray = new int[3][,];

// Creating the first 2x2 matrix
int[,] matrix1 = new int[,]
{
    { 1, 2 },
    { 3, 4 }
};

// Creating the second 2x2 matrix
int[,] matrix2 = new int[,]
{
    { 5, 6 },
    { 7, 8 }
};

// Creating the third 2x2 matrix
int[,] matrix3 = new int[,]
{
    { 9, 10 },
    { 11, 12 }
};

// Assigning the matrices to the jagged array
jaggedArray[0] = new int[,] { matrix1, matrix2 };
jaggedArray[1] = new int[,] { matrix2, matrix3 };
jaggedArray[2] = new int[,] { matrix3, matrix1 };

// Printing the jagged array in a cubic manner
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
    {
        for (int k = 0; k < jaggedArray[i].GetLength(1); k++)
        {
            for (int l = 0; l < jaggedArray[i][j, k].GetLength(0); l++)
            {
                for (int m = 0; m < jaggedArray[i][j, k].GetLength(1); m++)
                {
                    Console.Write(jaggedArray[i][j, k][l, m] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
