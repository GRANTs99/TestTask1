int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Fibonachi: {Fibonachi(n)}");
int k = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"n^m: {Degree(k, m)}");

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int Degree(int n, int m)
{
    if (m == 0) return 1;
    if (m == 1) return n;
    return n * Degree(n, m - 1);
}