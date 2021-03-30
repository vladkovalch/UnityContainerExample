using System;
using UnityContainerExample.Helpers;

namespace UnityContainerExample.Interfaces
{
    public interface ICarEntity
    {
        public string Name { get; set; }
        public ICarBehavior CarBehaviour { get; set; }

        public bool StartCar(IDriver driver)
        {
            Helpers.ShowConsoleMessage.ShowMessage($"Starting a {Name}.", MessageType.Info);
            return driver.DriverBehavior.BuckleUp() &&
                   CarBehaviour.StartEngine(driver.DriverBehavior.InsertKeys());
        }
    }
}