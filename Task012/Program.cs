/*Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/


Console.WriteLine("Введите число:");
int usernumber = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите второе число:");
int usernumber2 = Convert.ToInt32 (Console.ReadLine());

/*string DivCheck (int num1, int num2)
{
    if ( num1 % num2 == 0 ) 
    {
        return $"{num1}, {num2} -> кратно" ;
    } else {
        return $"{num1}, {num2} -> не кратно, остаток "+(num1 % num2);
    }
}
*/

bool DivCheck (int num1, int num2)
{
    return num1 % num2 == 0;
}

if (DivCheck(usernumber, usernumber2))
{
    
}
else
{
    Console.WriteLine("остаток "+(usernumber % usernumber2));
}

bool res = DivCheck(usernumber,usernumber2);
Console.WriteLine(res);
