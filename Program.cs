﻿// ПРАКТИЧЕСКОЕ ЗАДАНИЕ 4

// Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//     Console.WriteLine ("введите число A:  ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("введите число B:  ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     int step = a;
        
//           for (int i = 1; i < b; i++)
         
//           step = step * a;
         
// Console.WriteLine($"{a},{b} -> " + step);

    //    решено ! 


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int  sum=0;
 
//  while (i > 0 )
//      {
//        int num = i % 10 ;
//         i=i/10;
//         sum=sum+num;   
//           }
//      Console.WriteLine("сумма чисел = " + sum);   
         
//          !!!!

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] numbers = new int [8];

for (int i = 0; i < numbers.Length; i++)
{
numbers [i] = new Random().Next(0, 11);
Console.Write(" " + array (i) + ", ");

int array (int a)
{
return numbers[a];}
 Console.Write(" [ " + "] ");}

                                                                            