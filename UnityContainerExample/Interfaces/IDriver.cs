using System.Collections.Generic;

namespace UnityContainerExample.Interfaces
{
    public interface IDriver
    {
        public List<ICarEntity> Cars { get; set; }
        public IDriverBehavior DriverBehavior { get; set; }

        public void PrepareAndStartCar(ICarEntity carEntity);
    }
}