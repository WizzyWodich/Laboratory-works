using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Class.Computers
{
    abstract class BaseComputer
    {
        private readonly string type;
        private string modelName;
        private string operatingSystem;


        public BaseComputer(string type, string modelName, string operatingSystem)
        {
            this.type = type;
            this.modelName = modelName;
            this.operatingSystem = operatingSystem;
        }
        public string Type { get{return type; } private set {}}
        public string ModelName { get{return modelName; } private set {}}
        public string OperatingSystem {get{return operatingSystem;} private set {}}

        public abstract void OutputInfo();
    }
}




