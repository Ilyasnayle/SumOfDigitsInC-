
/*
 * Author = Ilyas Nayle
 * P.I- Works Technical Assessment question
 * Check divisibility of a given number by sum of its digits
 * e.g = 75  = 7 + 5 = 12 and 75 is not divisible by 12
 * e.g = 12 = 1 + 2 = 3 and 12 is divisible by 3
 */

namespace SumOfDigits;

public class CheckDivisibility
{
    public CheckDivisibility()
    {
    }

    public static void Main(String[] args)
    {
        CheckDivisibility digits = new CheckDivisibility();
        Console.WriteLine("Enter a number:");

        int userDigits = Convert.ToInt32(Console.ReadLine());
        Is_Divisible(userDigits);
    }

    public int abs_Value(int num)
    {
        if (num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        }
    }

    private static void Is_Divisible(int num)
    {
        int temp = num;
        int sum = 0;

        while (temp > 0)
        {
            sum = sum + (temp % 10);
            temp = (int) (temp / 10);
        }

        
        if ( num % sum  == 0)
        {
            Console.WriteLine("The sum of digits is: "+ sum);
            Console.WriteLine(num+ " is divisible by "+ sum);
            Console.WriteLine("True");
        }
        else
        {
                
            Console.WriteLine("The sum of digits is: "+ sum);
            Console.WriteLine(num+ " is not divisible by "+ sum);
            Console.WriteLine("False");
        }

    }
}