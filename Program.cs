using System.Text;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static (int max, int min, int sum, char firstLetter) CalculateValues(int[] numbers, string text)
            {
                int max = numbers[0];
                int min = numbers[0];
                int sum = 0;
                char firstLetter = text.Length > 0 ? text[0] : '\0';

                foreach (int num in numbers)
                {
                    if (num > max)
                        max = num;

                    if (num < min)
                        min = num;

                    sum += num;
                }

                return (max, min, sum, firstLetter);
            }
            static void CheckedExample()
            {
                try
                {
                    checked
                    {
                        int maxValue = int.MaxValue;
                        Console.WriteLine($"Значение в блоке checked: {maxValue}");
                        maxValue++;
                        Console.WriteLine($"После увеличения: {maxValue}");
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Исключение в блоке checked: {ex.Message}");
                }
            }

            static void UncheckedExample()
            {
                unchecked
                {
                    int maxValue = int.MaxValue;
                    Console.WriteLine($"Значение в блоке unchecked: {maxValue}");
                    maxValue++;
                    Console.WriteLine($"После увеличения: {maxValue}");
                }
            }
            int chose;
            void zadanie1()
            {

                bool isAlive = true;
                bool isDead = false;

                System.Boolean isRunning = true;
                System.Boolean isPaused = false;

                byte byteValue = 10;
                sbyte sbyteValue = 5;
                short shortValue = 6;
                ushort ushortValue = 7;
                int intValue = 42;
                uint uintValue = 200U;
                long longValue = 10000;
                ulong ulongValue = 12000;

                char charValue = 'A';

                float fValue = 1.12f;
                double dValue = 55.23;
                decimal decValue = 34.345m;

                string strValue = "Michail";
                //string strValue1 = "Litvin";

                Console.WriteLine("[[[[[[[[[[[[Булевые[[[[[[[[[[[");
                isAlive = bool.Parse(Console.ReadLine());
                Console.WriteLine(isAlive);
                isDead = bool.Parse(Console.ReadLine());
                Console.WriteLine(isDead);
                isRunning = bool.Parse(Console.ReadLine());
                Console.WriteLine(isRunning);
                isPaused = bool.Parse(Console.ReadLine());
                Console.WriteLine(isPaused);
                Console.WriteLine("[[[[[[[[[[[[[Целые[[[[[[[[[[[[");
                byteValue = byte.Parse(Console.ReadLine());
                Console.WriteLine(byteValue);
                sbyteValue = sbyte.Parse(Console.ReadLine());
                Console.WriteLine(sbyteValue);
                shortValue = short.Parse(Console.ReadLine());
                Console.WriteLine(shortValue);
                ushortValue = ushort.Parse(Console.ReadLine());
                Console.WriteLine(ushortValue);
                intValue = int.Parse(Console.ReadLine());
                Console.WriteLine(intValue);
                uintValue = uint.Parse(Console.ReadLine());
                Console.WriteLine(uintValue);
                longValue = long.Parse(Console.ReadLine());
                Console.WriteLine(longValue);
                ulongValue = ulong.Parse(Console.ReadLine());
                Console.WriteLine(ulongValue);
                Console.WriteLine("[[[[[[[[[[[[[Символьный[[[[[[[[[[[");
                charValue = char.Parse(Console.ReadLine());
                Console.WriteLine(charValue);
                Console.WriteLine("[[[[[[[[[[[[[Плавающая точка[[[[[[[[[[[");
                fValue = float.Parse(Console.ReadLine());
                Console.WriteLine(fValue);
                dValue = double.Parse(Console.ReadLine());  
                Console.WriteLine(dValue);
                decValue = decimal.Parse(Console.ReadLine());
                Console.WriteLine(decValue);
                Console.WriteLine("[[[[[[[[[[[[[Строки[[[[[[[[[[");
                strValue = Console.ReadLine();
                Console.WriteLine(strValue);
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                Console.WriteLine("Работа с классом Convert и явн и неявн привидения");

                int intValue1 = 5;
                double doubleValue = Convert.ToDouble(intValue1);
                Console.WriteLine(doubleValue);

                string numberString = "123";
                int number = Convert.ToInt32(numberString);
                Console.WriteLine(number);

                double doubleValue1 = 3.14;
                int intValue2 = Convert.ToInt32(doubleValue1);
                Console.WriteLine(intValue2);

                bool isTrue = true;
                string boolString = Convert.ToString(isTrue);
                Console.WriteLine(boolString);

                char character = 'A';
                int charValue1 = Convert.ToInt32(character);
                Console.WriteLine(charValue1);


                int intValue3 = 5;
                double doubleValue2 = intValue3;
                Console.WriteLine(doubleValue2);

                double doubleValue3 = 3.14;
                decimal decimalValue1 = (decimal)doubleValue3;
                Console.WriteLine(decimalValue1);

                int intValue4 = 12345;
                long longValue1 = intValue4;
                Console.WriteLine(longValue1);

                int myInt = 123;
                decimal myDecimal = myInt;
                Console.WriteLine(myDecimal);

                int iValue = 234;
                float flValue = iValue;
                Console.WriteLine(flValue);


                Console.WriteLine("Упаковка инт в обджект");

                int inttValue = 42;
                object boxedValue = inttValue;
                Console.WriteLine(boxedValue);

                Console.WriteLine("Распаковка из обджект в инт");

                object boxedValue1 = 42;
                int intt1Value = (int)boxedValue1;
                Console.WriteLine(intt1Value);


                Console.WriteLine("Неявно тип. переменные");
                var age = 25;
                Console.WriteLine(age);
                var name = "John";
                Console.WriteLine(name);
                var prices = new double[] { 10.99, 20.49, 5.75 };
                Console.WriteLine(prices);


                int? nullableInt = null;
                double? nullableDouble = 3.14;
                bool? nullableBool = true;

                if (nullableInt.HasValue)
                {
                    Console.WriteLine("Nullable int: " + nullableInt.Value);
                }
                else
                {
                    Console.WriteLine("Nullable int is null");
                }

                if (nullableDouble.HasValue)
                {
                    Console.WriteLine("Nullable double: " + nullableDouble.Value);
                }
                else
                {
                    Console.WriteLine("Nullable double is null");
                }

                if (nullableBool.HasValue)
                {
                    Console.WriteLine("Nullable bool: " + nullableBool.Value);
                }
                else
                {
                    Console.WriteLine("Nullable bool is null");
                }


            }

            void zadanie2()
            {
                string str1 = "Hello";
                string str2 = "Hello";

                Console.WriteLine(String.Equals(str1, str2));

                string str3 = "kyle";
                string str4 = "Vatslav";

                Console.WriteLine(String.Equals(str3, str4));

                string word1 = "Fabian's company";
                string word2 = "ABCDEFG";
                string sents = "I'm very like go to computer class";

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string cocatstr = word1 + word2;
                Console.WriteLine(cocatstr);

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string copystr = string.Copy(sents);
                Console.WriteLine(copystr);

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string substr = sents.Substring(4, 5);
                Console.WriteLine(substr);

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string[] words = sents.Split(' ');
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string insertedString = sents.Insert(4, "not");
                Console.WriteLine(insertedString);

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string deletedSubstring = sents.Replace("computer ", "");
                Console.WriteLine(deletedSubstring);

                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string name = "Acid";
                int age = 16;

                Console.WriteLine($"{name} , {age}");
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string emptyString = "";
                //string emptyString = String.Empty;

                string nullString = null;

                if (string.IsNullOrEmpty(emptyString))
                {
                    Console.WriteLine("empty");
                }
                if (string.IsNullOrEmpty(nullString))
                {
                    Console.WriteLine("null");
                }
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                if (nullString != null)
                {
                    int length = nullString.Length;
                    Console.WriteLine(length);
                }
                else
                {
                    Console.WriteLine("Строка была null");
                }
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                StringBuilder stringbr = new StringBuilder("Всем привет, меня зовут Кайл!");

                stringbr.Remove(4, 9);
                Console.WriteLine(stringbr);
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                stringbr.Insert(0, "123");
                Console.WriteLine(stringbr);
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                stringbr.Append("))");
                Console.WriteLine(stringbr);
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

            }
            void zadanie3()
            {
                int[,] matx = { { 1, 2, 3, 6 }, { 9, 7, 6, 5 }, { 10, 34, 7, 45 } };

                int rows = matx.GetLength(0);
                int cols = matx.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.WriteLine(matx[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");

                string[] stroki = new string[] { "abcd", "dcef", "fgec", "dfjl" };

                foreach (string item in stroki)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(stroki.Length);

                Console.Write("Введите позицию элемента для изменения (от 0 до 2): ");
                int position = Convert.ToInt32(Console.ReadLine());

                if (position >= 0 && position < stroki.Length)
                {
                    Console.Write("Введите новое значение элемента: ");
                    string newValue = Console.ReadLine();
                    stroki[position] = newValue;
                    Console.WriteLine($"Элемент на позиции {position} изменен.");
                }
                else
                {
                    Console.WriteLine("Позиция вне допустимого диапазона.");
                }
                foreach (string item in stroki)
                {
                    Console.WriteLine(item);
                }

                double[][] jaggedArray = new double[][] {
                new double[] { 1.1, 1.2 },
                new double[] { 2.1, 2.2, 2.3 },
                new double[] { 3.1, 3.2, 3.3, 3.4 }
                };


                Console.WriteLine("Введите значения для ступенчатого массива (3 строки, в каждой из которых 2, 3 и 4 столбцов):");
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write($"Введите значение для [{i}][{j}]: ");
                        jaggedArray[i][j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                var implicitlyTypedArray = new[] { 1, 2, 3, 4, 5 };
                var implicitlyTypedString = "Пример текста";

                Console.WriteLine("Неявно типизированный массив:");
                foreach (var item in implicitlyTypedArray)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("\nНеявно типизированная строка:");
                Console.WriteLine(implicitlyTypedString);

            }

            void zadanie4()
            {
                (int, string, char, string, ulong) t1 = (5, "hello", 'A', "Luke", 3000000);

                Console.WriteLine(t1);

                Console.WriteLine(t1.Item1);
                Console.WriteLine(t1.Item3);
                Console.WriteLine(t1.Item4);

                var (item1, item2, item3, item4, item5) = t1;

                Console.WriteLine($"item1: {item1}");
                Console.WriteLine($"item2: {item2}");
                Console.WriteLine($"item3: {item3}");
                Console.WriteLine($"item4: {item4}");
                Console.WriteLine($"item5: {item5}");

                (int, char, string, ulong) t2 = (234, 'C', "Sarah", 16256734);
                (int, char, string, ulong) t3 = (56, 'B', "Tony", 66667676);

                Console.WriteLine(Equals(t2, t3));
            }

            do
            {
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");
                Console.WriteLine("1 Задание - Типы и работа с ними");
                Console.WriteLine("2 Задание - Строки и работа с ними");
                Console.WriteLine("3 Задание - Массивы");
                Console.WriteLine("4 Задание - Кортежи");
                Console.WriteLine("5 Задание - Функции");
                Console.WriteLine("6 Задание - cheked/uncheked");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[");
                chose = int.Parse(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        zadanie1();
                        break;
                    case 2:
                        zadanie2();
                        break;
                    case 3:
                        zadanie3();
                        break;
                    case 4:
                        zadanie4();
                        break;
                    case 5:
                        int[] numbers = { 10, 5, 7, 3, 15 };
                        string text = "Hello, World!";

                        var result = CalculateValues(numbers, text);

                        Console.WriteLine($"Максимальный элемент массива: {result.max}");
                        Console.WriteLine($"Минимальный элемент массива: {result.min}");
                        Console.WriteLine($"Сумма элементов массива: {result.sum}");
                        Console.WriteLine($"Первая буква строки: {result.firstLetter}");
                        break;
                    case 6:
                        CheckedExample();
                        UncheckedExample();
                        break;
                    case 0:
                        break;
                }
            } while (chose != 0);
        }
    }
}
