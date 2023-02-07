// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int Number1 = int.Parse(Console.ReadLine());
int revers = 0;
int temp = Number1;

while (temp > 0)
{
    int Number2 = temp % 10;
    temp = temp / 10;
    revers = revers * 10 + Number2;
}

if (Number1 == revers) 
{
Console.WriteLine("Число - палиндром");
}
else
{
Console.WriteLine("Число - не палиндром");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.Write(numSQRT);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter number: ");

int number = int.Parse(Console.ReadLine());

int I = 1;

while(I <= number)
{
     Console.Write(Math.Pow(I, 3)+ " ");
     I++;
}