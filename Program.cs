using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть шестизначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100000 || number > 999999)
        {
            Console.WriteLine("Помилка: Введене число не є шестизначним.");
        }
        else
        {
            Console.Write("Введіть номер першого розряду для заміни: ");
            int index1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть номер другого розряду для заміни: ");
            int index2 = Convert.ToInt32(Console.ReadLine());

            int result = SwapDigits(number, index1, index2);
            Console.WriteLine($"Результат: {result}");
        }
    }

    
    static int SwapDigits(int number, int index1, int index2)
    {
      
        string numberString = number.ToString();

        if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
        {
            Console.WriteLine("Помилка: Введені неправильні номери розрядів.");
            return number;
        }

        
        int arrayIndex1 = index1 - 1;
        int arrayIndex2 = index2 - 1;

        
        char[] digits = numberString.ToCharArray();

        
        char temp = digits[arrayIndex1];
        digits[arrayIndex1] = digits[arrayIndex2];
        digits[arrayIndex2] = temp;

        
        return Convert.ToInt32(new string(digits));
    }
}
