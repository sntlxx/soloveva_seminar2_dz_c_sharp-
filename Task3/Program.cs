System.Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine ());
if (number >= 10 && number <= 99)
{
int first = number / 10;
int second = number % 10;
if (first > second)
{
    System.Console.WriteLine($"{first} является большим");
}
else if (second > first)
{
    System.Console.WriteLine($"{second} является большим");
}
else if (first == second)
{
    System.Console.WriteLine($"{first} и {second} равны друг другу");
}
}



else
{
    System.Console.WriteLine("Введено неверное число!");
}