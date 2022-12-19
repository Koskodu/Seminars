/*Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10, 100); //генерирует случайное целое число в диапазоне
Console.WriteLine(number);

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit) 
//    Console.WriteLine($"Наибольшая цифра = {firstDigit}");
//else 
//    Console.WriteLine($"Наибольшая цифра = {secondDigit}");
// если выполняется - то записываем первую переменную, если нет, то вторую
//int result = firstDigit > secondDigit ? firstDigit : secondDigit; //если условие выполняется то значение возвращается в result (Тернарный оператор)
//Console.WriteLine($"Наибольшая цифра = {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра = {maxDigit}");


//   имя метода
int MaxDigit(int number) //Мутод(функция) может находиться в любом месте
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
