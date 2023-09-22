using System.Globalization;
using System.Net.Security;

int[] numbers = { 3, 4, 8 }; // lista på int
string[] words = { "hello", "world", "foo" }; // Lista på ord

//numbers[1] = 4; // ändrar plats "2" till "4"

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// 2 -> {2, 3, 1}
// 3 -> {2, 1, 3}
// 2 -> {2, 3, 1}

sort();
sort();
void sort()
{

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int a = numbers[i];
        int b = numbers[i + 1];

        if (a > b)
        {
            numbers[i] = b;
            numbers[i + 1] = a;
        }
    }
}


foreach (int a in numbers)
{
    Console.WriteLine(a);
}
/*
------------------------------------------------------------------
int[] sort = new int[numbers.Length];
int biggest = 0;
for (int i = 0; i < numbers.Length; i++)
{
    foreach (var num in numbers)
    {
        if (num > biggest)
        {
            biggest = num;
        }
    }
    for (int j = 0; j < numbers.Length; j++)

    {
        if (numbers[j] == biggest)
        {
            sort[i] = numbers[j];
            numbers[j] = 0;
            biggest = 0;
        }
    }
}

foreach (int a in sort)
{
    Console.WriteLine(a);
}


*/