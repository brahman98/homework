using static System.Console;

public class Program
{
    public static void Main()
    {
        Run();
    }

    public static void Run()
    {
        // Вводим значения m и n
        Write("Введите значение m: ");
        int m = int.Parse(ReadLine());

        Write("Введите значение n: ");
        int n = int.Parse(ReadLine());

        // Проверка, чтобы m и n были неотрицательными числами
        if (m < 0 || n < 0)
        {
            WriteLine("Значения m и n должны быть неотрицательными.");
            return;
        }

        // Вычисление функции Аккермана
        int result = Ackermann(m, n);

        // Вывод результата
        WriteLine($"A({m},{n}) = {result}");
    }

    // Метод для вычисления функции Аккермана
    public static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
