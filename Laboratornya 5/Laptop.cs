using PersonalComputers;
using System;


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
    }
}
