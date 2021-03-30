using System;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Factories
{
    public static class JapaneseCarFactory 
    {
        public static ICarEntity GetCarEntity<T>(string carName)
        {
            return carName switch
            {
                Constants.MAZDA_CAR => (ICarEntity)UnityContainerManager.Container.Resolve(typeof(ICarEntity), Constants.MAZDA_CAR),
                Constants.NISSAN_CAR => (ICarEntity)UnityContainerManager.Container.Resolve(typeof(ICarEntity), Constants.NISSAN_CAR),
                Constants.TOYOTA_CAR => (ICarEntity)UnityContainerManager.Container.Resolve(typeof(ICarEntity), Constants.TOYOTA_CAR),
                _ => throw new NotImplementedException($"Creation of {typeof(T)} is not supported yet."),
            };
        }
    }
}