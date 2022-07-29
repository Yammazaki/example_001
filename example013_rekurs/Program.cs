/* string [,] table = new string [2, 5];
// table [0,0]   table[0,1] table[0,2] ... table[0,4]
//table [1,0]    table[1,1] table[2,2]

table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for( int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[rows, columns]}--");
    }
} */

int[,] matrix = new int[3,4];
void PrintArray (int[,] matr)
{
for (int i = 0; i < 3; i++) // вместо 3 можно использовать matrix.GetLength(0), где 0 это 3Б 3 это кстати количество строк
{
    for (int j = 0; j < 4; j++) // а здесь мы можем использовать также matrix.GetLength(1), где 1 это будет 4-ой количество столбцов
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}
PrintArray(matrix);