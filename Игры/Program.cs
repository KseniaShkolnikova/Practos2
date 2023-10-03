
using System;
using System.CodeDom.Compiler;

string red = "0";
while (red != "4")
{
    Console.WriteLine("Выберите программу: ");
    Console.WriteLine("1. Игра: Угадай число");
    Console.WriteLine("2. Таблица умножения ");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Выход из программы");
    red = Console.ReadLine();
    if (red == "1")
    {
        Console.WriteLine("Программа загадала число. Угадайте его.");
        Random sa = new Random();
        int pa = sa.Next(0, 100);
        int rae;
        do
        {
            rae = Convert.ToInt32(Console.ReadLine());
            if (rae == pa)
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
            else
            {
                if (rae > pa)
                {
                    Console.WriteLine("Введите число поменьше");
                }
                else
                {
                    Console.WriteLine("Введите число побольше");
                }
            }


        } while (rae != pa);

    }
    else if (red == "2")
    { 
        int [,] Matrix = new int[9, 9];
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write((i * j) + "\t");

            }
            Console.WriteLine();
           
        }
        
    }
    else if (red == "3") 
    {
        Console.WriteLine("Введите число");
        int chislo = Convert.ToInt32 (Console.ReadLine());
        int i=1;
        int ted;
        while (chislo  >= i ) 
        {
            
            if (chislo % i == 0) 
            {
                ted  = chislo / i;
                Console.Write(ted + " " + "\t" );
                
            }
            i++;
        }
        Console.Write("\n");
    }

    else if (red== "4")
    {
        Console.WriteLine("пока");
    }
}
