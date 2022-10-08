// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"{number} - Палиндром");
}
else
{
    Console.WriteLine($"{number} - НЕ палиндром");
}
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату x первой точки: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату y первой точки: ");
double y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату z первой точки: ");
double z2 = Convert.ToDouble(Console.ReadLine()!);

double len1 = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между точками {len1:f2}");

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
int counter = 1;
int length = cube.Length;
while (counter <  length){
   cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
   counter++;
}
}
void PrintArry(int[] coll){
int count = coll.Length;
int index = 1;
while(index < count){
Console.Write(coll[index]+ " ");
index++;
}
} 
int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);