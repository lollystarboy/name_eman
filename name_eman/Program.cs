﻿namespace name_eman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свое имя");

            var name =  Console.ReadLine();

            for (int i = name.Length- 1; i >= 0; i--)
            {
                Console.WriteLine(name[i] + " ");
            }
        }
    }
}
