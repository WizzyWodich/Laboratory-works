using Computers;
using System;

namespace PersonalComputers
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

    }
}
