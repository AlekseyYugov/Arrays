using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            for (int j = 0; j < arr1.Length; j++) //заполнение первого массива
            {
                arr1[j] = rand.Next() % 10;
            }

            for (int j = 0; j < arr2.Length; j++) //заполнение второго массива
            {
                arr2[j] = rand.Next() % 10;
            }

            Console.WriteLine("Первый массив:");
            foreach (var item in arr1) // вывод первого массива
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Второй массив:");
            foreach (var item in arr2) // вывод второго массива
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            // проверяем на повторения элементы и записываем в третий массив
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i]==arr2[j])
                    {                        
                        k++;
                    }
                }
            }
            int[] arr3 = new int[k];
            k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {                        
                        arr3[k] = arr1[i];
                        k++;                        
                    }
                }
            }

            // выводим третий массив
            Console.WriteLine("Третий массив содержит повторения значиний первых двух массивов: ");
            if (arr3.Length ==0)
            {
                Console.WriteLine("Повторений нет!");
            }
            else 
            {
                foreach (var item in arr3)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // проверка на палиндром
            Console.WriteLine("Введите строку, для проверки является ли она полиндромом");
            string str = Console.ReadLine();
            char[] stroka2 = new char[str.Length];
            char[] stroka1 = new char[str.Length];
            for (int i = str.Length,j = 0; i > 0; i--,j++)
            {
                stroka1[j] = str[i-1];
                Console.Write(stroka1[j]);
            }
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                stroka2[i] = str[i];
                Console.Write(stroka2[i]);
            }
            Console.WriteLine();
            int p = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (stroka1[i]==stroka2[i])
                {

                }    
                else
                {
                    p = 0;
                }
                
            }
            if (p == 0)
            {
                Console.WriteLine("НЕ является палиндромом");
            }
            else
            {
                Console.WriteLine("является палиндромом");
            }
            Console.WriteLine();
            //подсчет слов в строке
            int slovo = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (stroka2[i]==' ')
                {
                    if (stroka2[i+1]!=' ')
                    {
                        slovo++;
                    }
                }
            }
            Console.WriteLine("В строке " + (slovo+1) + " слов(а)");
            Console.WriteLine();

            //подсчет элементов между минимальным и максимальным элементами массива
            Random rand2 = new Random();
            int[,] array = new int[5,5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand2.Next(-100,100);
                }
            }
            int max = array[0, 0];
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                    if (array[i, j] > max) max = array[i, j];
                    if (array[i, j] < min) min = array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Минимальное значение = " + min);
            Console.WriteLine("Максимальное значение = " + max);
            int minindex1 = 0;
            int minindex2 = 0;
            int maxindex1 = 0;
            int maxindex2 = 0;
            int summ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j]<array[minindex1,minindex2])
                    {
                        minindex1 = i; // нахождение индексов у минимального и максимального
                        minindex2 = j;
                    }
                    else if (array[i, j] > array[minindex1, minindex2])
                    {
                        maxindex1 = i;
                        maxindex2 = j;
                    }
                }
            }
            
            for (int i = minindex1; i <= maxindex1; i++) //подсчет суммы элементов от минимального до максимального
            {
                for (int j = minindex2; j <= maxindex2; j++)
                {
                    summ += array[i, j];
                }
            }
            summ -= (min + max);
            
            Console.WriteLine("Сумма элементов между минимальным и максимальным элементами или между максимальным и минимальным = " + summ);
            Console.WriteLine();
        }
    }
}
