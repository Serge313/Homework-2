int number = GetNumber("Enter your number ");
int count = CountDigits(number);
int[] array = new int [count];
FillArrayAndFindThirdDigit(array, number);

//Использую функцию PrintArray для проверки заполнения массива
void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]);
    }
}


void FillArrayAndFindThirdDigit(int[] array1, int a)
{
    if (a > 99)
    {
        for (int i = array1.Length - 1; i >= 0; i--)
        {
            int cutDigit = a % 10;
            array[i] = cutDigit;
            a = a / 10;
        }
        Console.WriteLine(array1[2]);
        PrintArray(array);
    }
    else
    {
        Console.WriteLine("There is no third digit!");
    }
}


int CountDigits(int a)
{
    int count = 0;
    int rest = a;
    while (a != 0)
    {
        rest = a / 10;
        a = a / 10;
        count ++;
    }
    return count;
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}