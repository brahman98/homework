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

        // Вычисление суммы натуральных чисел от M до N
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            if (i > 0) // Проверяем, что число натуральное (больше 0)
            {
                sum += i;
            }
        }

        // Вывод результата
        WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна {sum}");
    }
}
