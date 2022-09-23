int number = GetNumber("Enter your three-digit number ");
CutDigits(number);

void CutDigits(int a)
{
    int secondDigit = 0;
    if (a > 99 && a < 1000)
    {
        Console.WriteLine(secondDigit = (a % 100) / 10);
    }
    else
    {
        Console.WriteLine("Please enter a three-digit number!");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}