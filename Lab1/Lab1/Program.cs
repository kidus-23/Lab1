using System;
using Lab1;
namespace Class1;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        string i = Console.ReadLine();
        int ia = Convert.ToInt32(i);
        if (ia % 2 == 0)
            Console.WriteLine("The value is even.");
        else
            Console.WriteLine("The value is odd.");

        while (ia % 2 != 0)
        {
            ia++;
        }
        switch (ia % 2)
        {
            case 0:
                Console.WriteLine("The number is even now.");
                break;
            default:
                Console.WriteLine("The number is " + i + "% 2");
                break;
        }
        char c = '*';
        for (int j = 0; j < 5; j++)
        {
            Console.Write(c);
        }

        Student s = new Student();
        s.id = 3;
        s.name = "Kidus";
    }
    }
}
