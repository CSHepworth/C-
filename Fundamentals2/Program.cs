﻿int[] samples = { 2, 10, 3 };
int[] sampleAllNegative = { -5, -2, -6 };
int[] shiftingExample = { 1, 5, 10, 7, 2 };
int[] sampleNumToString = { -1, 13, 2 };

static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

PrintNumbers();

static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

PrintOdds();

static void PrintSum()
{
    int sum = 0;
    for (int i = 1; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"New Number: {i} Sum: {sum}");
    }
}

PrintSum();

static void LoopArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

LoopArray(samples);

static int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

Console.WriteLine(FindMax(sampleAllNegative));

static void GetAverage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    int avg = sum / numbers.Length;
    Console.WriteLine(avg);
}

GetAverage(samples);

static List<int> OddList()
{
    List<int> Odds = new List<int>();
    for (int i = 0; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Odds.Add(i);
        }
    }
    return (Odds);
}

OddList();


static int GreaterThanY(int [] numbers, int y)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > y)
        {
            count += 1;
        }
    }
    return (count);
}

Console.WriteLine(GreaterThanY(samples, 2));

static void SquareArrayValues(int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        int sqr = numbers[i] * numbers[i];
        numbers[i] = sqr;
        Console.WriteLine(numbers[i]);
    }
}

SquareArrayValues(samples);

static void EliminateNegatives(int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
            numbers[i] = 0;
        else
            numbers[i] = numbers[i];
        Console.WriteLine(numbers[i]);
    }
}

EliminateNegatives(sampleAllNegative);