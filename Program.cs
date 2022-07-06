//Задача 15 палиндром
Console.WriteLine("Введите пятизначное число");
string Chislo = Console.ReadLine();

void Zadacha15(string Chislo)
{
    if (Chislo[0] == Chislo[4] && Chislo[1] == Chislo[3])
    {
      Console.WriteLine("Число являетcя палиндромом");
    }
    else 
    { 
     Console.WriteLine("Число не являетcя палиндромом");
    }
}

Zadacha15(Chislo);



//Задача 21 расстояние в 3D

void Zadacha21 (int x1,int x2, int y1, int y2, int z1, int z2)
{
    double Length = 0;
    Length = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
    Console.WriteLine(Length);
}
Zadacha21(1,2,7,4,5,8);



//Задача 23 кубы чисел
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

void Zadacha23(int N)
{
 int i = 1;
 while (i<=N)
 {
  Console.Write(i*i*i + "  ");
  i++;
 }
 
}
Zadacha23(N);

