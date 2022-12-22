/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
Проверка на пятизначность обязательна
14212 -> нет
12821 -> да
23432 -> да*/

//Строково:
Console.WriteLine($"Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num / 10000 < 1){
      Console.WriteLine($"Введите любое ПЯТИЗНАЧНОЕ число");
}
string Num = Convert.ToString(num);
if (Num[0] == Num[4] && Num[1]== Num[3]){
      Console.WriteLine($"Ваше число является полиндромом");
}
else{
      Console.WriteLine($" НЕТ!!! Ваше число не является полиндромом");
}

//Математически:
Console.WriteLine($"Введите любое пятизначное число");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 <= 9999){
      Console.WriteLine($"Введите любое ПЯТИЗНАЧНОЕ число");
}
else{
      if (num1 / 10000 == num1 % 10 && num1 / 1000 % 10 == num1 /10 % 10){
      Console.WriteLine($"Ваше число является полиндромом");
      }
      else{
            Console.WriteLine($" НЕТ!!! Ваше число не является полиндромом");
      }
}


/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine($"Введите X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите Z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow( x2-x1 , 2 ) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между точками: {result:f2}");


/*Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine($"Введите число N");
int N = int.Parse(Console.ReadLine()!);
for(int a = 1; a <= N; a++){
    Console.WriteLine($"{ Math.Pow(a, 3)}");
}