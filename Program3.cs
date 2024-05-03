//Программирование Итоговое 3

// Произвольный массив
char[] array = new char [] {'a','g','7','G','l'};
int count=array.Length-1;

PrntReverse (array, count);

void PrntReverse (char[] STR, int a)
{
    if (a>=0) 
    {
    Console.Write(STR[a]);
    PrntReverse (array, --a);
    }
}