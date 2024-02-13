using SelectMenu.General;
using Class.PersonalComputers;
using System;
using System.CodeDom.Compiler;


namespace Class.Laptops
{
    internal class Laptop : PersonalComputer
    {
        private int batteryСapacity;
        public Laptop (string type, string modelName, string operatingSystem, int arm, int batteryСapacity ) : base(type, modelName, operatingSystem, arm)
        {
            this.batteryСapacity = batteryСapacity;
        }
        public int BatteryСapacity { get { return batteryСapacity; } private set { } }
        public override void OutputInfo()
        {
            Console.WriteLine($"Краткая информация о электроном устройстве: " +
                                $"\n Тип: {this.Type} " +
                                $"\n Модель {this.Type}: {this.ModelName} " +
                                $"\n Операционная система: {this.OperatingSystem}" +
                                $"\n Архитектура процесора: {this.Arm}" +
                                $"\n Ёмкость батареи: {this.BatteryСapacity}mAh\n");

        }

        public void Calculator(PersonalComputer personalComputer, Laptop laptop)
        {
            Console.WriteLine("Выбран Калькулятор");
            Console.WriteLine("Выберите операцию (введите цифру):");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("ESC. Выйти из програмы");
            Console.WriteLine("Bacspase. Начальное меню");

            int choice;
            while (true)
            {
                try
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    char keyChar = keyInfo.KeyChar;

                    if (keyInfo.Key == ConsoleKey.Backspace)
                    {
                        GeneralSelectionMenu.clearConsole();
                        GeneralSelectionMenu.selectMenu(personalComputer, laptop);
                        break;
                    }

                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("Програма завершила свою работу.");
                        Environment.Exit(0);
                    }

                    else if (char.IsDigit(keyChar))
                    {
                        choice = int.Parse(keyChar.ToString());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Вы выбрали Сложение");
                                Addition();
                                return;
                            case 2:
                                Console.WriteLine("Вы выбрали Вычитание");
                                Subtraction();
                                return;
                            case 3:
                                Console.WriteLine("Вы выбрали Умножение");
                                Multiplication();
                                return;
                            case 4:
                                Console.WriteLine("Вы выбрали Деление");
                                Division();
                                return;
                            default:
                                Console.WriteLine("Ошибка: выбранная операция не найдена.");
                                break;
                        }
                    } // else if
                    else
                    {
                        Console.WriteLine("Ошибка: введите цифру.");
                    }
                
                } // try
                catch (Exception ex)
                {
                    Console.WriteLine("В ходе выполнения програмы возникла ошибка. Обратитесь к разработчику.");
                    Console.WriteLine($"Ошибка: {ex.Message}");
                } // catch
                finally{
                    Console.WriteLine("Спасибо что воспользовались методом. Удачи");
                } // finaly
            } // while
        } // public

        private void Addition()
        {
            Console.Write("Введите первое число:");
            int varFirst = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int varSecond = int.Parse(Console.ReadLine());

            Console.Write($"Результат сложения: {varFirst + varSecond}");
        }

        private void Subtraction()
        {
            Console.Write("Введите первое число:");
            int varFirst = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int varSecond = int.Parse(Console.ReadLine());

            Console.Write($"Результат вычитания: {varFirst - varSecond}");
        }

        private void Multiplication()
        {
            Console.Write("Введите первое число:");
            int varFirst = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            int varSecond = int.Parse(Console.ReadLine());

            Console.Write($"Результат умножения: {varFirst * varSecond}");
        }

        private void Division()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число:");
                    int varFirst = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число:");
                    int varSecond = int.Parse(Console.ReadLine());
                    if(varFirst != 0)
                    {
                        Console.Write($"Результат деления: {varFirst / varSecond}");
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль!");
                        continue;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
            }
        }

        public void Scheduler()
        {
            try
            {
                Console.WriteLine("Введите количество дел на сегодня:");
                int size = int.Parse(Console.ReadLine());
                if (size <= 0)
                {
                    throw new ArgumentException("Число не может быть отрицательным.");
                }

                int[] array = CreateAndPopulateScheduler(size);

                Console.WriteLine("Все ваши дела на сегодня:");
                PrintArray(array);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректный формат ввода.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком большое для обработки.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        private int[] CreateAndPopulateScheduler(int size)
        {
            int[] array = new int[size];

            Console.WriteLine($"Введите {size} чисел для заполнения массива:");
            for (int i = 0; i < size; i++)
            {
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Ошибка при вводе числа {i + 1}. Попробуйте еще раз.");
                    i--; 
                }
            }

            return array;
        }

        private void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

    }
}

