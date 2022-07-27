Console.WriteLine("Задайте значение M");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Recursion(numberOne, numberTwo);

void Recursion(int numberOne, int numberTwo, int sum = 0)
{
    if (numberOne > numberTwo)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += numberOne;
    numberOne++;
    Recursion(numberOne, numberTwo, sum);
}