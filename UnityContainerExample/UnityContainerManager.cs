using Unity;
using UnityContainerExample.Behaviours;
using UnityContainerExample.Entities;
using UnityContainerExample.Entities.Cars;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample
{
    public static class UnityContainerManager
    {
        public static IUnityContainer Container { get; }

        static UnityContainerManager()
        {
            Container = new UnityContainer();
        }

        public static void RegisterTypes()
        {
            Container
                .RegisterType<ICarEntity, Mazda>(Constants.MAZDA_CAR)
                .RegisterType<ICarEntity, Nissan>(Constants.NISSAN_CAR)
                .RegisterType<ICarEntity, Toyota>(Constants.TOYOTA_CAR)
                .RegisterType<ICarBehavior, CarDefaultBehavior>()
                .RegisterType<IDriverBehavior, DriverDefaultBehavior>()
                .RegisterSingleton<IDriver, Driver>("Bob");
        }
    }
}