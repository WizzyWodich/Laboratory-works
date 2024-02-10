using System;
using Class.Computers;
using Class.PersonalComputers;
using Class.Laptops;
using SelectMenu.General;

namespace Laboratornya_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer computer = new PersonalComputer("PersonalComputer", "N2133b", "Windows 11", 64);
            computer.OutputInfo();
            

            Laptop laptop = new Laptop("Laptop", "Aser Nitro 7+", "Windows 10 Home", 64, 3200);
            laptop.OutputInfo();

            Console.ReadLine();
            SelectMenu.General.GeneralSelectionMenu.clearConsole();
            SelectMenu.General.GeneralSelectionMenu.selectMenu(laptop, computer);

            
            
             // Порядок на день
            
            Console.ReadLine();
        }
    }
}
