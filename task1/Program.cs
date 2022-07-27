Console.WriteLine("Задайте значение M");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Recursion(numberOne, numberTwo);

void Recursion(int numberOne, int numberTwo)
{
    if (numberOne > numberTwo) return;
    if (numberOne%3 ==0)
    {
    Console.Write(numberOne + "  ");
    }
    numberOne++;
    Recursion(numberOne, numberTwo);
}