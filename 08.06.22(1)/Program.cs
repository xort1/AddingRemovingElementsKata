using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise2;

            Random random = new Random();

            Console.WriteLine("---Добавление | Удаление элементов массива---\n");
            Console.WriteLine("Введите количество эелементов массива...");
            int count = int.Parse(Console.ReadLine());

            int[] Array = new int[count];

            for (int i = 0; i < Array.Length; i++)
                Array[i] = random.Next(10);

            Console.WriteLine("\nПолучившийся массив:");
            for (int i = 0; i < Array.Length; i++)
                Console.WriteLine($"Array[{i}] = {Array[i]}\t");

            Console.WriteLine("\n1 - Добавить элементы\n2 - Удалить элементы\nВыберите, что делать с массивом...");
            int choise = int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    Console.WriteLine("\n1 - Добавить эл-т в начало массива\n2 - Добавить эл-т в конец массива\n3 - Добавить эл-т в массив по индексу");
                    choise2 = int.Parse(Console.ReadLine());
                    switch(choise2)
                    {
                        case 1:
                            addStart(ref Array, random);
                            break;

                        case 2:
                            addEnd(ref Array, random);
                            break;

                        case 3:
                            addElement(ref Array, random);
                            break;

                        default:
                            Console.WriteLine("Ошибка!");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("\n1 - Удалить эл-т из начала массива\n2 - Удалить эл-т из конца массива\n3 - Удалить эл-т из массива по индексу");
                    choise2 = int.Parse(Console.ReadLine());
                    switch (choise2)
                    {
                        case 1:
                            removeStart(ref Array, random);
                            break;

                        case 2:
                            removeEnd(ref Array, random);
                            break;

                        case 3:
                            removeElement(ref Array, random);
                            break;

                        default:
                            Console.WriteLine("Ошибка!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
        }

        static void addStart(ref int[] Array, Random random)
        {
            Console.WriteLine("\nДобавление элемента в начало...\n");

            int size = Array.Length;
            size++;

            int[] ArrayMove = new int[size];

            Array.CopyTo(ArrayMove, 1);

            ArrayMove[0] = random.Next(10);

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }

        static void addEnd(ref int[] Array, Random random)
        {
            Console.WriteLine("\nДобавление элемента в конец\n");

            int size = Array.Length;
            size++;

            int[] ArrayMove = new int[size];

            Array.CopyTo(ArrayMove, 0);

            ArrayMove[Array.Length] = random.Next(10);

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }

        static void addElement(ref int[] Array, Random random)
        {
            Console.WriteLine("\nДобавление элемента по индексу\n");

            Console.WriteLine("Введите индекс эл-та, который хотите добавить (с 0-го)");
            int chose3 = int.Parse(Console.ReadLine());

            int size = Array.Length;
            size++;

            int[] ArrayMove = new int[size];

            ArrayMove[chose3] = random.Next(10);

            for (int i = 0; i < chose3; i++)
                ArrayMove[i] = Array[i];

            for (int i = chose3; i < Array.Length; i++)
                for (int j = ++chose3; j < ArrayMove.Length; j++)
                    ArrayMove[j] = Array[i];

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }

        static void removeStart(ref int[] Array, Random random)
        {
            Console.WriteLine("\nУдаление элемента из начала\n");

            int size = Array.Length;
            size--;

            int[] ArrayMove = new int[size];

            for (int i = 0; i < ArrayMove.Length; i++)
            {
                ArrayMove[i++] = Array[i];
                i--;
            }

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }

        static void removeEnd(ref int[] Array, Random random)
        {
            Console.WriteLine("\nУдаление элемента из конца\n");

            int size = Array.Length;
            size--;

            int[] ArrayMove = new int[size];

            for (int i = 0; i < ArrayMove.Length; i++)
            {
                ArrayMove[i] = Array[i++];
                i--;
            }

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }

        static void removeElement(ref int[] Array, Random random)
        {
            Console.WriteLine("\nУдаление элемента по индексу\n");

            Console.WriteLine("Введите индекс эл-та, который хотите удалить (с 0-го)");
            int chose3 = int.Parse(Console.ReadLine());

            int size = Array.Length;
            size--;

            int[] ArrayMove = new int[size];

            for (int i = 0; i < chose3; i++)
                ArrayMove[i] = Array[i];

            for (int i = chose3; i < Array.Length; i++)
            {
                for (int j = ++chose3; j < Array.Length; j++)
                { 
                    ArrayMove[i] = Array[j];
                    break;
                }
            }

            Array = new int[size];

            ArrayMove.CopyTo(Array, 0);

            Console.WriteLine("Получившийся массив:\n");
            for (int i = 0; i < Array.Length; i++)
                Console.Write($"Array[{i}] = {Array[i]}\t");
            Console.ReadLine();
        }
    }
}