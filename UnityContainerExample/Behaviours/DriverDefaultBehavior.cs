using UnityContainerExample.Helpers;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Behaviours
{
    public class DriverDefaultBehavior : IDriverBehavior
    {
        public bool BuckleUp()
        {
            Helpers.ShowConsoleMessage.ShowMessage("Getting in the driver's seat and buckling up.", "DRIVER'S ACTION", MessageType.Info);
            return true;
        }

        public bool InsertKeys()
        {
            Helpers.ShowConsoleMessage.ShowMessage("Inserting the key into the ignition and twisting them.", "DRIVER'S ACTION", MessageType.Info);
            return true;
        }
    }
}