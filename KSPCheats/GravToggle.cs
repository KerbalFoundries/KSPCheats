using System;
using UnityEngine;

namespace KSPCheats
{

    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class GravToggle : MonoBehaviour
    {
        bool gravCheat;
        double GeeASL;

        public void Start()
        {
            GeeASL = FlightGlobals.ActiveVessel.mainBody.GeeASL;
        }

        public void Update()
        {
            if (Input.GetKeyUp(KeyCode.O))
            {
                gravCheat = !gravCheat;
                if (gravCheat)
                    FlightGlobals.ActiveVessel.mainBody.GeeASL = 0;
                else
                    FlightGlobals.ActiveVessel.mainBody.GeeASL = GeeASL;
            }
        }
    }
}
