Console.Write("Введите число которое будем возводить в степень: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i < N) Console.Write(", ");
}