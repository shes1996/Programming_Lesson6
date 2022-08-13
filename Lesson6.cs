
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Zadacha41()
{
int count = 0;
Console.WriteLine("Введите количество чисел");
int M = int.Parse(Console.ReadLine());
for (int i = 0; i < M; i++)
{
if (int.Parse(Console.ReadLine()) > 0) count += 1;
}
Console.WriteLine("Количество чисел больше 0: {0}", count);
}
//Zadacha41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
void Zadacha43()
{
Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
if (k1 != k2) 
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: ({0},{1})", x, y);
}
else Console.WriteLine("Прямые параллельны");
}
//Zadacha43();

//Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.
void ZadachaAdd1()
{
int number = int.Parse(Console.ReadLine());
string number_bin = "";
void NumberToBinary(int number, ref string number_bin)
{
    if (number > 0)
    {
        int doub = number % 2;
        number_bin += doub;
        number /= 2;
        NumberToBinary(number, ref number_bin);
    }
}
void Reverse(string number_bin, ref string binary, int count = 0)
{
    if (count != number_bin.Length)
    {
    binary += number_bin[number_bin.Length - count - 1];
    ++count;
    Reverse(number_bin, ref binary, count);
    }
}
string binary = "";
NumberToBinary(number, ref number_bin);
Reverse(number_bin, ref binary);
Console.WriteLine(number_bin);
Console.WriteLine(binary);
}
//ZadachaAdd1();

// Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
// Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.
void ZadachaAdd2()
{
string proverb = "без труда не выловишь и рыбку из пруда";
char[] vowels = {'ё','у','е','ы','а','о','э','я', 'и', 'ю'};
void CountVowels(string proverb, char[] vowels, int count = 0, int i = 0)
{
    if (i < proverb.Length)
    {
        for (int j = 0; j < vowels.Length; ++j)
        {
            if (proverb[i] == vowels[j])
            {
                ++count;
            }
        }
        CountVowels(proverb, vowels, count, ++i);
    }
    else Console.WriteLine(count);
}
CountVowels(proverb, vowels);
}
//ZadachaAdd2();

// Задача 3. Дано число N. Используя только операцию деления и рекурсию, определите, 
// что оно является степенью числа 3.
void ZadachaAdd3()
{
int number = int.Parse(Console.ReadLine());

void Pow3(int number)
{
    if (number > 2 && number % 3 == 0)
    {
        number /= 3;
        Pow3(number);
    }
    else if (number == 1) Console.WriteLine("Число является степенью 3");
        else Console.WriteLine("Число не является степенью 3");
}
Pow3(number);
}
//ZadachaAdd3();