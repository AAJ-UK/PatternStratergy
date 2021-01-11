using ConsoleApp2.Aircraft;
using ConsoleApp2.Engines;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Tryin to uderstand the Stratergy Pattern
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // We have some airbourne machinery and have derived 3 classes from it
            // Helicopter, Jet Plane and a TurboProp Plane.
            // The base class AirborneMachinery is abstract as we never want to create it, because its not and never will be a real thing
            // Each item of airbourne machinery must eventually be installed with an engine.

            JetPlane myJetPlane = new JetPlane();
            TurboPropPlane myTurboPropPlane = new TurboPropPlane();
            Helicoptor myHelicopter = new Helicoptor();

            // It would be possible to add the engine in the constuctor, but that would make it more diffuicult
            // for different Aircraft of the same type (Jet,Tubo,Helicopter) to have different engine models
            // we would have to create a new class for each engine model.
            // by setting it as a method, we get an extra layer of abstraction.
            // we could create M2,M3 models of each engine and as we build the plane adde them here.

            myJetPlane.SetEngine(new JetPlaneEngineEngineM1());
            myTurboPropPlane.SetEngine(new TurboPropEngineM1());
            myHelicopter.SetEngine(new HelicopterTurbineEngineM1());

            // because the are all the same base class, they can all be added to a common list

            List<AirborneMachinery> myFlyingMachines = new List<AirborneMachinery>();
            myFlyingMachines.Add(myJetPlane);
            myFlyingMachines.Add(myTurboPropPlane);
            myFlyingMachines.Add(myHelicopter);

            // and we can use the baseclass to start the engines
            foreach (AirborneMachinery AM in myFlyingMachines)
            {
                AM.StartEngine();
            }

            Console.WriteLine("Changing engine in my Jet Plane");
            myJetPlane.SetEngine(new JetPlaneEngineEngineM2());
            myJetPlane.StartEngine();




        }
    }
}
