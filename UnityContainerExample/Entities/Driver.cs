using System;
using System.Collections.Generic;
using UnityContainerExample.Helpers;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Entities
{
    public class Driver : IDriver
    {
        public List<ICarEntity> Cars { get; set; }
        public IDriverBehavior DriverBehavior { get; set; }

        public Driver(IDriverBehavior driverBehavior)
        {
            Cars = new List<ICarEntity>();
            DriverBehavior = driverBehavior;
        }

        public void PrepareAndStartCar(ICarEntity carEntity)
        {
            if (carEntity == null)
            {
                Helpers.ShowConsoleMessage.ShowMessage("The car entity is not initialized properly!", MessageType.Error);
                return;
            }

            carEntity.StartCar(this);
            Helpers.ShowConsoleMessage.ShowMessage($"{carEntity.Name} is ready for a ride.", MessageType.Done);
            Console.WriteLine();
        }
    }
}