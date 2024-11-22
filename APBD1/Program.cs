// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Tablica nie moze byc pusta i/lub byc nullem");
    }

    int sum = 0;

    for(int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return (double)sum / numbers.Length;
}

int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);
Console.WriteLine(average);

Console.WriteLine("Zmiana do rebase'u");

static int FindMax(int[] numbers)
{
    return numbers.Max();
}

Console.WriteLine(FindMax(numbers));
