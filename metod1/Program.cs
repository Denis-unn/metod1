using System;
using System.Collections.Generic;

class Metod1
{
    static void Main()
    {
        Stack<int> stek = new Stack<int>();

        string command;
        while ((command = Console.ReadLine()) != "exit")
        {
            string[] parts = command.Split();
            string op = parts[0];

            switch (op)
            {
                case "push":
                    try
                    {
                        int number = int.Parse(parts[1]);

                        stek.Push(number);
                        Console.WriteLine("ok");
                        break;
                    }
                    catch (Exception e)
                    {
                        // Console.WriteLine(e.ToString());
                        Console.WriteLine("Некорректный ввод (вы ввели не число)");
                        break;
                    }

                case "pop":
                    int poppedNumber = stek.Pop();
                    Console.WriteLine(poppedNumber);
                    break;

                case "back":
                    int topNumber = stek.Peek();
                    Console.WriteLine(topNumber);
                    break;

                case "size":
                    int size = stek.Count;
                    Console.WriteLine(size);
                    break;

                case "clear":
                    stek.Clear();
                    Console.WriteLine("ok");
                    break;
                default:
                    Console.WriteLine("Вы написали некорректную команду для стека");
                    break;
            }
        }

        Console.WriteLine("Bye");
    }
}