using System.ComponentModel;
using System.Runtime.CompilerServices;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

void Multiplicity()
{
    Clear();
    WriteLine("Программа \"кратность 5 - 3\" ");
    WriteLine("Введите число от 1 до 100");
    int range = Convert.ToInt32(ReadLine());
    if (range % 3 == 0 && range % 5 == 0)
    {
        WriteLine("Fizz Buzz");
    }
    else if (range % 3 != 0 && range % 5 != 0)
    {
        WriteLine($"{range}");
    }
    else if (range % 5 == 0)
    {
        WriteLine("Buzz");
    }
    else if (range % 3 == 0)
    {
        WriteLine("Fizz");
    }
}

void Percentages()
{
    Clear();
    WriteLine("Программа расчёта процентов");
    WriteLine("Введите число ");

    int number = Convert.ToInt32(ReadLine());

    WriteLine("Введите проценты ");

    int percentages = Convert.ToInt32(ReadLine());
    int result = (number * percentages) / 100;

    WriteLine($"{percentages} процентов от {number} равно {result}");
}

void CompositeNumber()
{
    Clear();
    WriteLine("Программа составное число");
    WriteLine("Введите четыре числа через запятую ");
    string? text = ReadLine();
    string[] textsplit = text.Split('\n');
    foreach (string str in textsplit)
    {
        string[] strsplit = str.Split(',');
        for (int i = 0; i < strsplit.Length; i = i + 4)
        {
            WriteLine(strsplit[i] + strsplit[i+1] + strsplit[i+2] + strsplit[i + 3] + "\n");
        }
    
    }
}

void PermutationNumbers()
{
    Clear();
    WriteLine("Программа перестановки введённых чисел");
    WriteLine("Введите число не менее двух символов");
    string? NumberText = ReadLine();
    char[] NumberChar = NumberText.ToCharArray();
    WriteLine("Веедите порядковый номер первого числа");
    int NumberReplace1 = Convert.ToInt32(ReadLine());
    NumberReplace1 -= 1;
    WriteLine("Введите порядковый номер второго числа");
    int NumberReplace2 = Convert.ToInt32(ReadLine());
    NumberReplace2 -= 1;
    var Buffer = NumberChar[NumberReplace1];
    NumberChar[NumberReplace1] = NumberChar[NumberReplace2];
    NumberChar[NumberReplace2] = Buffer;
    NumberText = new string(NumberChar);
    int Number = Convert.ToInt32(NumberText);
    WriteLine("Изменённое число" + Number);
}

void Temperature()
{
    Clear();
    WriteLine("Программа перевода температуры из Цельсия в Фарингейта и наоборот");
    double F = 0;
    double C = 0;
    WriteLine("Введите температур");
    Write(">> ");
    double Temperature = Convert.ToInt32(ReadLine());
    WriteLine("Выберите вариант конвертации температуры");
    WriteLine("1 - В Фарингейта");

    WriteLine("2 - В Цельсия");
    int menu = Convert.ToInt32(ReadLine());
    switch (menu)
    {
        case 1:
            F = (Temperature * 9) / 5 + 32;
            WriteLine("Температура по фарингейту: " + F);
            break;
        case 2:
            C = (Temperature - 32) * 5 / 9;
            WriteLine("Температура по цельсию: " + C);
            break;
    
    }
}

void EvenNumbers()
{
    Clear();
    WriteLine("Программа показа чётных чисел из диапазона");
    WriteLine("Введите начало диапазона");
    int BeginningRange = Convert.ToInt32(ReadLine());
    WriteLine("Введите окончание диапазона");
    int EndningRange = Convert.ToInt32(ReadLine());
    if (BeginningRange > EndningRange)
    {
        WriteLine("Нормализация диапазона проведена");
        int BufferRange = BeginningRange;
        BeginningRange = EndningRange;
        EndningRange = BufferRange;
        WriteLine("Теперь");
        WriteLine("Начало диапазона = " + BeginningRange);
        WriteLine("Конец диапазона = " + EndningRange);
    }
    int NumberElements = EndningRange - BeginningRange+1;
    int[] Arr = new int[NumberElements];
    for (int i = BeginningRange, j = 0; i<=EndningRange && j<NumberElements; i++, j++)
    {
        Arr[j] = i;
    }
    WriteLine("Последовательность находящаяся в диапазопе заданных чисел");
    foreach (int i in Arr)
    {
        Write(i + " ");
    }
    WriteLine();
    WriteLine("Последовательность чётных чисел в диапазопе от " + BeginningRange + " до " + EndningRange);
    foreach (int i in Arr)
    {
        if (i%2==0)
        {
        Write(i + " ");
        }
    }
    WriteLine();
}



Clear();
Title = "Первое ДЗ по C#";
WriteLine("Введите номер программы: ");
WriteLine("1 - Программа \"кратность 5 - 3\" ");
WriteLine("2 - Программа \"расчёт процентов\"");
WriteLine("3 - Программа \"составное число\" ");
WriteLine("4 - Программа \"перестановка введённых чисел\"");
WriteLine("5 - Программа ");
WriteLine("6 - Программа \"перевод температуры из Цельсия в Фарингейта и наоборот\" ");
WriteLine("7 - Программа \"чётные числа из диапазона\"");
WriteLine("8 - Выход из программы ");
Write(">> ");
int NumberMenu = Convert.ToInt32(ReadLine());

    switch (NumberMenu)
    {
        case 1:
            Multiplicity();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 2:
            Percentages();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 3:
            CompositeNumber();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 4:
            PermutationNumbers();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 5:
            break;
        case 6:
            Temperature();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 7:
            EvenNumbers();
            Write("Для продолжения нажмите ENTER");
            Read();
            break;
        case 8:
            break;
    }

