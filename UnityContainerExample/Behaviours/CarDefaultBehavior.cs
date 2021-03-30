using UnityContainerExample.Helpers;
using UnityContainerExample.Interfaces;

namespace UnityContainerExample.Behaviours
{
    public class CarDefaultBehavior : ICarBehavior
    {
        public bool StartEngine(bool isKeysIntoIgnition)
        {
            if (isKeysIntoIgnition)
            {
                Helpers.ShowConsoleMessage.ShowMessage("The engine has started.", "CAR RESPONSE", MessageType.Info);
                return true;
            }

            Helpers.ShowConsoleMessage.ShowMessage("There is no keys in the ignition!", "CAR RESPONSE", MessageType.Error);
            return false;
        }
    }
}