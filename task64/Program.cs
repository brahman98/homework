using static System.Console;

public class Program
{
    public static void Main()
    {
        Run();
    }

    public static void Run()
    {
        // Вводим значения M и N
        Write("Введите значение M: ");
        int M = int.Parse(ReadLine());

        Write("Введите значение N: ");
        int N = int.Parse(ReadLine());

        // Проверка, чтобы M было меньше или равно N
        if (M > N)
        {
            WriteLine("Значение M должно быть меньше или равно значению N.");
            return;
        }

        // Вывод всех натуральных чисел от M до N
        Write("Натуральные числа в промежутке от M до N: ");
        for (int i = M; i <= N; i++)
        {
            if (i > 0) // Проверяем, что число натуральное (больше 0)
            {
                Write(i);
                if (i < N) Write(", ");
            }
        }
        WriteLine();
    }
}
