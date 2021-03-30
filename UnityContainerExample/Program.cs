using System;
using UnityContainerExample.Factories;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainerManager.RegisterTypes();
            
            var driver = (IDriver)UnityContainerManager.Container.Resolve(typeof(IDriver), "Bob");
            
            driver.Cars.Add(JapaneseCarFactory.GetCarEntity<ICarEntity>(Constants.MAZDA_CAR));
            driver.Cars.Add(JapaneseCarFactory.GetCarEntity<ICarEntity>(Constants.NISSAN_CAR));
            driver.Cars.Add(JapaneseCarFactory.GetCarEntity<ICarEntity>(Constants.TOYOTA_CAR));

            foreach (var car in driver.Cars)
            {
                driver.PrepareAndStartCar(car);
            }

            Console.ReadKey(true);
        }
    }
}
