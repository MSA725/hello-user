﻿ 
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет Машуля");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

    
}