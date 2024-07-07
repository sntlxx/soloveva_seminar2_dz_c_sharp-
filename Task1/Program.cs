
// введите число, проверяет, кратно ли оно 7 и 23 одновременно
using System.Runtime.Serialization.Formatters;

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine ());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("число кратно 7 и 23 одновременно");
}
else 
{
    System.Console.WriteLine("число не кратно 7 и 23 одновременно");
}