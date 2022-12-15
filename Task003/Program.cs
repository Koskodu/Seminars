/*Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите номер дня недели: ");
int user_input = (Console.ReadLine());
string weekday = "";

if (user_input == "1")
{
    weekday = "Понедельник";
}
else if (user_input == "2")
{
    weekday = "вторник";
}
else if (user_input == "3")
{
    weekday = "среда";
}
else if (user_input == "4")
{
    weekday = "четверг";
}
else if (user_input == "5")
{
    weekday = "пятница";
}
else if (user_input == "6")
{
    weekday = "суббота";
}
else if (user_input == "7")
{
    weekday = "Воскресенье";
}
else Console.WriteLine("не верный ввод! введите существующий номер дня недели");

Console.WriteLine($"{user_input} >> {weekday}");