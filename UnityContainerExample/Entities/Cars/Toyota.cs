using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Entities.Cars
{
    public class Toyota : ICarEntity
    {
        public string Name { get; set; }
        public ICarBehavior CarBehaviour { get; set; }

        public Toyota(ICarBehavior carBehaviour)
        {
            Name = Constants.TOYOTA_CAR;
            CarBehaviour = carBehaviour;
        }
    }
}