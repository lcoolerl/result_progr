//Программирование Итоговое 1

// Ввод чисел
Console.Write("Введите число а: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число б: ");
int b=Convert.ToInt32(Console.ReadLine());

// Первый вызов функции
if (a<b)
{
PrintAllNumbers (a+1, b);
}
if (b<a)
{
PrintAllNumbers (b+1, a);
}
// Функция
void PrintAllNumbers(int c, int d)
{
    if (c<d)
    {
        Console.Write ($"{c} ");
    PrintAllNumbers (++c, d);
    }
}