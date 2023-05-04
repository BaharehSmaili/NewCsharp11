using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp11
{
    public class AutoDefaultStructs
    {
        public void PrintCar(string name) 
        {
            Car car = new Car(name);
            Console.WriteLine("Id is : " +  car.Id.ToString() + " Name is : " + car.Name);
        }
    }
    struct Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // old version
        public Car(int id,string name)
        {
            Id = id;
            Name = name;
        }

        // new version C# 11
        public Car() { }

        // new version C# 11
        public Car(string name) 
        {
            Name = name;
        }
    }
}
