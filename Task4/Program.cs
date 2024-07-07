Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
 Console.WriteLine("Вы ввели некорректное число.");
}
else
{
 string numberString = number.ToString();
 for (int i = 0; i < numberString.Length; i++)
 {
 if (i > 0)
 {
 Console.Write(", ");
 }
 Console.Write(numberString[i]);
 }
}
