using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tРабота с массивами");
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++) // заполнение первого массива
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива целочисленным значением");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int number1, number2;
            number1 = 3; // строки 
            number2 = 4; // столбцы
            double[,] B = new double[number1, number2];
            Random rand = new Random();
            rand.NextDouble();

            for (int i = 0; i < number1; i++) // заполнение второго массива
            {
                for (int j = 0; j < number2; j++)
                {
                    B[i, j] = rand.NextDouble();
                }
            }

            for (int i = 0; i < A.Length; i++) // вывод первого массива
            {
                Console.Write(A[i]);
                Console.Write('\t');
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < number1; i++) // вывод второго массива
            {
                for (int j = 0; j < number2; j++)
                {
                    Console.Write(B[i, j]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            double max = A[0];
            double min = A[0];
            double sum = 0;
            double proizved = 1;
            double sumchet = 0;
            double sumnechet = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]>max) // нахождение максимального элемента первого массива
                {
                    max = A[i];
                }
                if (A[i]<min) // нахождение минимального элемента первого массива
                {
                    min = A[i];
                }
                sum += A[i]; // нахождение суммы элементов первого массива
                proizved *= A[i]; // нахождение произведения элементов первого массива
                if (A[i] % 2 == 0) // нахождение суммы четных элементов первого массива
                {
                    sumchet += A[i];
                }
                if (A[i] % 2 != 0) // нахождение суммы нечетных элементов первого массива
                {
                    sumnechet += A[i];
                }
            }

            Console.WriteLine("Сумма нечетных чисел массива_1 = " + sumnechet);
            Console.WriteLine("Сумма четных чисел массива_1 = " + sumchet);
            Console.WriteLine("Произведение массива_1 = " + proizved);
            Console.WriteLine("Сумма массива_1 = " + sum);
            Console.WriteLine("Минимальное значение массива_1 = " + min);
            Console.WriteLine("Максимальный элемент массива_1 = " + max);
            Console.WriteLine("====================================================");
            
            sum = 0; // обнуление данных для второго массива
            proizved = 1;
            sumchet = 0;
            sumnechet = 0;
            max = B[0, 0];
            min = B[0, 0];
            double sumnechetnumber2 = 0;

            for (int i = 0; i < number1; i++)
            {
                for (int j = 0; j < number2; j++)
                {
                    if (B[i,j]>max) // нахождение максимального элемента второго массива
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < max) // нахождение минимального элемента второго массива
                    {
                        min = B[i, j];
                    }
                    sum += B[i, j]; // нахождение суммы элементов второго массива
                    proizved *= B[i,j];
                    if (B[i,j] % 2 == 0) // нахождение суммы четных элементов второго массива
                    {
                        sumchet += A[i];
                    }
                    if (A[i] % 2 != 0) // нахождение суммы нечетных элементов второго массива
                    {
                        sumnechet += B[i,j];
                    }
                    if (j % 2 != 0)
                    {
                        sumnechetnumber2 += B[i, j];
                    }
                }
                
            }

            Console.WriteLine("Сумма нечетных чисел массива_2 = " + sumnechet);
            Console.WriteLine("Сумма четных чисел массива_2 = " + sumchet);
            Console.WriteLine("Произведение массива_2 = " + proizved);
            Console.WriteLine("Сумма массива_2 = " + sum);
            Console.WriteLine("Минимальное значение массива_2 = " + min);
            Console.WriteLine("Максимальный элемент массива_2 = " + max);
            Console.WriteLine("Сумма элементов в нечетных столбцах массива_2 = " + sumnechetnumber2);
        }
        
    }
}
