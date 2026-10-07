
// task1

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 4, 5, 6 };

//         int evenSum = 0;
//         int oddSum = 0;

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (i % 2 == 0)
//                 evenSum += numbers[i];
//             else
//                 oddSum += numbers[i];
//         }

//         Console.WriteLine("Сумма элементов на чётных индексах: " + evenSum);
//         Console.WriteLine("Сумма элементов на нечётных индексах: " + oddSum);

//         if (evenSum > oddSum)
//             Console.WriteLine("Сумма на чётных индексах больше.");
//         else if (oddSum > evenSum)
//             Console.WriteLine("Сумма на нечётных индексах больше.");
//         else
//             Console.WriteLine("Суммы равны.");
//     }
// }



// task2

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 4, 7, 2, 9, 5, 9, 3 };

//         int max = numbers[0];
//         int maxIndex = 0;

//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//                 maxIndex = i;
//             }
//         }

//         Console.WriteLine("Максимальный элемент: " + max);
//         Console.WriteLine("Индекс первого максимального элемента: " + maxIndex);
//     }
// }


// task 3
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr= new int[a];
// int cnt=0;
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a-1; i++)
// {
//     if (arr[i+1] > arr[i ])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine("The answer is: "+ cnt);


// task4
// int a=Convert.ToInt32(Console.ReadLine());
// int[] arr=new int[a];
// int cnt=0;
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a; i++)
// {
//     if (arr[i] < 0)
//     {
//         cnt++;
//         arr[i]=-arr[i];
//     }

// }
// System.Console.WriteLine("Changed: "+cnt);


// task5
// int a= Convert.ToInt32(Console.ReadLine());
// int cnt=0;
// int[] arr=new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < a; i++)
// {
//     if(arr[i]%2==0 && arr[i + 1] % 2 == 0)
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine("The max lenght: "+cnt);


// task 6
// int a=Convert.ToInt32(Console.Read());
// int rev=0;
// int[ ] arr= new int[a];
// for(int i = 0; i < a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.Read());
// }
// for(int i = a; i > 0; i /= 10)
// {
//     rev= rev * 10+i%10;
// }
// if (rev == a)
// {
//     System.Console.WriteLine("Yes it's a palindrom");
// }
// else
// {
//     System.Console.WriteLine("No it's not a palindrom");
// }

// 

// task8
// int a = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[a];

// for (int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// int left = arr[0];

// for (int i = 0; i < a - 1; i++)
// {
//     arr[i] = arr[i + 1];
// }

// arr[a - 1] = left;

// for (int i = 0; i < a; i++)
// {
//     Console.Write(arr[i] + " ");
// }


