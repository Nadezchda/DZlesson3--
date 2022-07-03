//  void getDot (int x, int y){
//  if (x ==0 || y ==0) {
//   Console.WriteLine(" нет возможности определить четвурть");
//  } else {
//     if (x > 0 && y > 0)
//     Console.WriteLine(" 1 четверть"); 
//     if (x > 0 && y < 0)
//     Console.WriteLine(" 4 четверть");
//     if (x < 0 && y > 0)
//     Console.WriteLine(" 2 четверть"); 
//     if (x < 0 && y < 0)
//     Console.WriteLine(" 3 четверть");
//  } 
//  }

//  Console.WriteLine(" Ввведите две точки");
//  int x1 =Convert.ToInt32(Console.ReadLine());
// int y1 =Convert.ToInt32(Console.ReadLine());

// getDot ( x1, y1);

// решена задача


// Написать программу которая по заданному номеру четвети 
// показывает диапозон возможных коордитат точек в этой четверти



//         void getDot(int num)
//        { if (num == 1)
//             Console.WriteLine(" x > 0 , y > 0");
//         else if (num == 2)
//             Console.WriteLine(" x < 0 , y > 0");
//         else if (num == 3)
//             Console.WriteLine(" x < 0 , y < 0");
//         else if (num == 4)
//             Console.WriteLine(" x > 0 , y < 0");
//         else 
//             Console.WriteLine(" введено некорректное число");

//     } 
//         Console.WriteLine(" введите номер четверти");
//  int  a = Convert.ToInt32(Console.ReadLine()); 
//  getDot (a);

//  задача решена !


    //     Console.Clear();
    //     double distAB(int x1, int y1, int x2, int y2){
    
    //         return Math.Sqrt(Math.Pow((x2 - x1), 2)+ Math.Pow((y2 - y1),2));
    //     }
    //     Console.WriteLine("Введите координату x1");
    //     int xA = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Введите координату y1");
    //     int yA = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Введите координату x2");
    //     int xB = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Введите координату y2");
    //     int yB = Convert.ToInt32(Console.ReadLine());

    //     Console.WriteLine("Длина отрезка = " + Math.Round(distAB(x1:xA, y1:yA, x2:xB, y2:yB),2));
       

    //    задача решена!!

    //  1 metod

//      int[] CreateRandomArray(int size, int min, int max){
//           int [] array = new int[size];
//           for(int i = 0; i < size; i++){
//           array[i] = new Random().Next(min,max+1);
//          }
//           return array;
//               }

// void ShowArray (int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
// Console.WriteLine();
// }

//  int [] myArray = CreateRandomArray(12, -9, 9);
//  ShowArray(myArray);
// int  sum_pos = 0;
// int  sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray [i] > 0)
//         sum_pos += myArray [i];
//     else sum_neg += myArray [i];
// }   
//    Console.WriteLine($"Сумма положительных: {sum_pos}. Cумма отрицательных: {sum_neg}");   

// ЗАДАЧА  32

//      int[] CreateRandomArray(int size){
//           int [] array = new int[size];
//           for(int i = 0; i < size; i++){
//           array[i] = new Random().Next(-100,100);
//          }
//           return array;
//   }
// int[] GetArray (int[] array)
// {
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i]* (-1); 
        //    или
//     }    array[i]* = (-1)
//      return array;   
// }
// void ShowArray (int [] array){
    
//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
// }
// int[] array = CreateRandomArray(10); 
// ShowArray(array);
// Console.WriteLine();
// ShowArray(GetArray(array));
// Задача решена !!!

// ПРАКТИЧЕСКОЕ ЗАДАНИЕ  К 3 УРОКУ

//  Задача 19 
// НАПИСАТЬ ПРОГРАММУ , КОТОРАЯ БУДЕТ ПРИНИМАТЬ
 // НА ВХОД 5ТИЗНАЧНОЕ ЧИСЛОИ ПРОВЕРЯЕТ ЯВЛЯЕТСЯ ЛИ ОНО ПОЛИНДРОМОМ 

 Console.WriteLine("Введите  число:");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if ( number[0] == number[4] & number[1] == number[3]) {
    Console.WriteLine($" {number} - палиндром.");
  }
  else Console.WriteLine($" {number} - НЕ палиндром.");
}
if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
// задача решена !

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//          double distAB(int x1, int y1,int z1,int x2, int y2, int z2){
    
//             return Math.Sqrt(Math.Pow((x2 - x1), 2)+ Math.Pow((y2 - y1),2)+ Math.Pow((z2 - z1),2));
//         }
//         Console.WriteLine("Введите координату x1");
//         int xA = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите координату y1");
//         int yA = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите координату z1");
//           int zA = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите координату x2");
//          int xB = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите координату y2");
//          int yB = Convert.ToInt32(Console.ReadLine());
//          Console.WriteLine("Введите координату z2");
//          int zB = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Длина отрезка = " + Math.Round(distAB(x1:xA, y1:yA, z1:xA, x2:xB, y2:yB,z2:zB ),2));
//        Задача решена ?


//      Задача 23
        // Напишите программу, которая принимает на вход число (A)
        //  и выдаёт сумму чисел от 1 до А.

//          int sumToNum( int num)
//          {
//           int sum=0;
//           for (int i = 1; i <=num; i++)
//           {
//             sum += i;
//           }
//           return sum;
//          }
//          Console.WriteLine("введите число :  ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Сумма элементов  " +  sumToNum(number));
