using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarTask
{
  
    public class Car
    {
        private static int _idCounter=1;

        public int Id { get; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public CarType Type { get; set; }

        public enum CarType
        {
            Sport,
            SUV, 
            Sedan
        }

        public Car(string brand, string model, CarType type)
        {
            Id = _idCounter++;
            Brand = brand;
            Model = model;
            Type = type;    

        }
        public override string ToString()
        {
            return $"Car Id:{Id},Brand:{Brand}, Model:{Model}, Type:{Type}";
        }

    }
}
