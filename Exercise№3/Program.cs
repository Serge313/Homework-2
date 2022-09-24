int digit = GetDigit("Enter your digit from 1 to 7 ");
WeekendsOrNot(digit);

void WeekendsOrNot (int a)
{
    if (a > 5 && a < 8)
    {
        Console.WriteLine($"{a} -> yes");
    }
    else if (a >=1 && a <= 5)
    {
        Console.WriteLine($"{a} -> no");
    }
    else
    {
        Console.WriteLine($"Your digit - \"{a}\" is more then 7 or less then 1!");
    }
}


int GetDigit(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}