//Программирование Итоговое 2

// Ввод чисел
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Первый вызов функции
if (m >= 0 && n >= 0)
{
   Console.Write(Akkerm(m, n));
}

// Функция
int Akkerm(int a, int b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return Akkerm(a - 1, 1);
    else return Akkerm(a-1, Akkerm(a,b-1));
}