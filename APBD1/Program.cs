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

    for(int changedI = 0; changedI < numbers.Length; changedI++)
    {
        sum += numbers[changedI];
    }

    return (double)sum / numbers.Length;
}

int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);
Console.WriteLine(average);

Console.WriteLine("Zmiana do rebase'u");