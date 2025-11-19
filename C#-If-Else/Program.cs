

using System.Diagnostics.CodeAnalysis;

static bool CheckIfEqual(int number1, int number2)
{
    bool isEqual = false;
    if (number1 == number2)
    {
        isEqual = true;
        Console.WriteLine("The numbers are equal");
    }
    else
    {
        isEqual = false;
        Console.WriteLine("The numbers are not equal");
    }
    if (!isEqual)
    {
        int sum = number1 + number2;
        Console.WriteLine($"The sum of the numbers are: {sum}");
    }
    else
    {
        int multiplied = number1 * number2;
        Console.WriteLine($"The numbers multiplied are: {multiplied}");
    }
        return isEqual;
}
Console.WriteLine($"The numbers are equal: {CheckIfEqual(3, 4)}");

static bool checkIf30(int number1, int number2)
{
    int sum = number1 + number2;
    if (number1 == 30 || number2 == 30 || sum == 30)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine($"One of the numbers or the sum of the numbers is 30: {checkIf30(26, 4)}");

////Misforstått oppgave 1
//Console.WriteLine("\nThis is the result of the misunderstood assignement:");
//MisunderstoodCheckIfEqual1();
//static void MisunderstoodCheckIfEqual1()
//{
//    int number1 = 3;
//    int number2 = 2;
//    bool isEqual = false;
//    if (number1 == number2)
//    {
//        isEqual = true;
//        Console.WriteLine("The numbers are equal");
//    }
//    else
//    {
//        isEqual = false;
//        Console.WriteLine("The numbers are not equal");
//    }
//    if (isEqual)
//    {
//        number1++;
//    }
//    else
//    {
//        number2--;
//    }
//    Console.WriteLine($"This is number1: {number1} \nand this is number2: {number2}");
//    Console.WriteLine($"This is the boolean: {isEqual}");
//}