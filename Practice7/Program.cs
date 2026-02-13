using System;
using JYM;

class Program
{
    static void Main()
    {
        Gym<string> gym = new Gym<string>();
        for (int i = 0; i < 1000; i++)
        {
            gym.Add($"Тренажёр номер {i}");
        }
        Console.WriteLine(gym[0]);
        Console.WriteLine(gym[500]);
        Console.WriteLine(gym[999]);
        gym.RemoveAt(0);
        gym.Insert(500, "Новое что то");
        Console.WriteLine(gym[500]);
        Console.WriteLine(gym[0]);
    }
}