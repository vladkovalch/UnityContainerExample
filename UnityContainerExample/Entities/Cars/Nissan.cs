using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Entities.Cars
{
    public class Nissan : ICarEntity
    {
        public string Name { get; set; }
        public ICarBehavior CarBehaviour { get; set; }

        public Nissan(ICarBehavior carBehaviour)
        {
            Name = Constants.NISSAN_CAR;
            CarBehaviour = carBehaviour;
        }
    }
}