using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Entities.Cars
{
    public class Mazda : ICarEntity
    {
        public string Name { get; set; }
        public ICarBehavior CarBehaviour { get; set; }

        public Mazda(ICarBehavior carBehaviour)
        {
            Name = Constants.MAZDA_CAR;
            CarBehaviour = carBehaviour;
        }
    }
}