using Class.Computers;
using System;
using System.Collections.Generic;
using System.IO;
using SelectMenu.General;
using Class.Laptops;


namespace Class.PersonalComputers
{
    class PersonalComputer : BaseComputer
    {
        private int arm;
        public PersonalComputer(string type, string modelName, string operatingSystem, int arm) : base (type, modelName, operatingSystem) 
        {
            this.arm = arm;
        }

        public int Arm { get { return arm; } private set { } }

        public override void OutputInfo()
        {
            Console.WriteLine($"Краткая информация о электроном устройстве: " +
                                $"\n Тип: {this.Type} " +
                                $"\n Модель {this.Type}: {this.ModelName} " +
                                $"\n Операционная система: {this.OperatingSystem}" +
                                $"\n Архитектура процесора: {this.arm}\n");
        }



        private string[] createdFiles = new string[0];
        private string directoryPath = @"C:\Users\kirya\Desktop\programing\Работы\Лабораторные\Laboratornya 5\files";

        public void Files(PersonalComputer personalComputer, Laptop laptop)
        {
            try
            {
                GeneralSelectionMenu.clearConsole();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Записать текст в файл");
                Console.WriteLine("2. Считать текст из файла");
                Console.WriteLine("3. Завершить программу");
                Console.WriteLine("4. Начальное меню");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteToFile(personalComputer, laptop);
                        break;
                    case "2":
                        ReadFromFile(personalComputer, laptop);
                        break;
                    case "3":
                        Environment.Exit(0);
                        return;
                    case "4":
                        GeneralSelectionMenu.clearConsole();
                        GeneralSelectionMenu.selectMenu(personalComputer, laptop);
                        break;
                    default:
                        Console.WriteLine("Выбрано неверное действие.");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите цифру.");
            }
            finally
            {
                Console.WriteLine("Спасибо что воспользовались методом. Удачи");
            }
        }

        private void WriteToFile(PersonalComputer personalComputer, Laptop laptop)
        {
            Console.WriteLine("Введите название файла (без расширения .txt): ");
            string fileName = Console.ReadLine();

            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            try
            {
                string filePath = Path.Combine(directoryPath, fileName + ".txt");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(text);
                }
                Console.WriteLine($"Текст успешно записан в файл '{fileName}.txt'.");
                AddFileToArray(fileName + ".txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        private void ReadFromFile(PersonalComputer personalComputer, Laptop laptop)
        {
            string[] files = Directory.GetFiles(directoryPath);
            if (files.Length == 0)
            {
                Console.WriteLine("Нет созданных файлов для чтения. Для начала создайте файл.");
                Console.ReadLine();
                Files(personalComputer, laptop);
                return;
            }

            Console.WriteLine("Выберите файл для чтения:");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
            }

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > files.Length)
            {
                Console.WriteLine("Неверный выбор файла.");
                return;
            }

            string selectedFile = files[choice - 1];

            try
            {
                string text = File.ReadAllText(selectedFile);
                Console.WriteLine($"Содержимое файла '{selectedFile}':");
                Console.WriteLine(text);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }


        private void AddFileToArray(string fileName)
        {
            Array.Resize(ref createdFiles, createdFiles.Length + 1);
            createdFiles[createdFiles.Length - 1] = fileName;
        }

        public void ThrowAnException()
        {
            try{ GeneralSelectionMenu.clearConsole();
                 throw new NullReferenceException(); }
            catch(Exception ex)
            {
                Console.WriteLine("Произошла ошибка");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Вызвав метод вы создали исключение");
            }
        }
    }
}

