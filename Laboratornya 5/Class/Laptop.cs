using Menu;
using PersonalComputers;
using System;
using System.Runtime.InteropServices;


namespace Laptops
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

        public void Calculator()
        {
            Console.WriteLine("Выбран Калькулятор");
            Console.WriteLine("Выберите операцию (введите цифру):");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            int choice;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                char keyChar = keyInfo.KeyChar;

                if (char.IsDigit(keyChar))
                {
                    choice = int.Parse(keyChar.ToString());
                    switch (choice)
                    {
                        case 1:
                            Addition();
                            return;
                        case 2:
                            Subtraction();
                            return;
                        case 3:
                            Multiplication();
                            return;
                        case 4:
                            Division();
                            return;
                        default:
                            Console.WriteLine("Ошибка: выбранная операция не найдена.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите цифру.");
                }
            }
        }

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
    }
}

