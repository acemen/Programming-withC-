using System;

public class Program
{
    public static void Main()
    {
        Q1();
        Q2();
        Q3();
        Q4();
        Q5();
    }
    public static void Q1()
    {
        int num1, num2, num3;
        Console.Write("\n\n");
        Console.Write("Find the largest of three numbers:\n");
        Console.Write("------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the 1st number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("The 1st Number is the greatest among three. \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
        }
        else if (num2 > num3)
            Console.Write("The 2nd Number is the greatest among three \n\n");
        else
            Console.Write("The 3rd Number is the greatest among three \n\n");
    }
    public static void Q2()
    {
        double number1, number2, number3;

        Console.Write("Enter the quiz score: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the mid-term score: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the final exam score: ");
        number3 = Convert.ToDouble(Console.ReadLine());


        double result = (number1 + number2 + number3) / 3;
        Console.WriteLine("The average of {0}, {1}, {2} is: {3} ", number1, number2, number3, result);
        if (result >= 90) Console.WriteLine("The grade is A");
        if ((result < 90) && (result >= 70)) Console.WriteLine("The grade is B");
        if ((result < 70) && (result >= 50)) Console.WriteLine("The grade is C");
        if (result <= 50) Console.WriteLine("The grade is F");
    }

    public static void Q3()
    {
        String number = "";
        Console.Write("Enter the number: ");
        number = Console.ReadLine();
        Console.WriteLine("The number of digits is: {0}", number.Length);
    }

    public static void Q4()
    {
        for (int i = 1; i < 123; i++)
        {
            Console.WriteLine(i + " = " + (char)i);

            if (i % 10 == 0)
            {
                Console.WriteLine(" ");

            }
        }
    }
    public static void Q5()
    {
        String s = "";
        Console.Write("Enter the number: ");
        s = Console.ReadLine();
        int result2 = s.Split('a').Length - 1;
        Console.WriteLine("The number of digits is: {0}", result2);
    }

}