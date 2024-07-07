System.Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine ());
System.Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine ());

if(x > 0 && y > 0)
{
    System.Console.Write("Плоскость I");
}
else if (x > 0 && y < 0)
    {
        System.Console.Write("Плоскость II");
    }
else if (x < 0 && y < 0)
    {
        System.Console.Write("Плоскость III");
    }
else if (x > 0 && y < 0)
    {
        System.Console.Write("Плоскость IV");
    }
else 
{
System.Console.WriteLine("Точка не принадлежит ни одной из нужных плоскостей");
}

