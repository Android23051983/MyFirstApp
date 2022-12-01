// See https://aka.ms/new-console-template for more information
//выводим пользователю сообщение
Console.Write("Введите целое число: ");
//получаем строку из консоли в строковую переменную
string numberString = Console.ReadLine();
//конвертируем строковое значение в числовое
int number = Int32.Parse(numberString);
//выводим результат
Console.WriteLine("Число = " + number);
