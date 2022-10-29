Console.WriteLine("Enter the 1 line of the matrix");
int[] st1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Enter the 2 line of the matrix");
int[] st2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Enter the 3 line of the matrix");
int[] st3 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int[][] matrix =
{
    st1,
    st2,
    st3
};
Console.WriteLine("Matrix");
foreach (int[] line in matrix)
{
    foreach (int i in line)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
int d = 0;
int k = 0;
for (int i = 0; i < matrix.Length; i++)
{
    d += matrix[i][i];
    k += matrix[i].Where(n => n % 3 == 0).Sum();
}
Console.WriteLine($"Sum of the numbers of the main diagonal: {d}");
Console.WriteLine($"Sum of the numbers of multiples of 3: {k}");