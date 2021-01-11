using ConsoleApp2.Engines;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2.Aircraft
{

    public abstract class AirborneMachinery
    {
        // mark as abstract as there an AirbourneMachinery is not a real object and
        // we need to prevent anyone from trying to instantiate it.

        // Define our base class, it will have ome mothod thich will be StartEngine
        // It will accept an engine object and allow the engine to be started
        public IEngine _engine;
        public void SetEngine(IEngine Engine)
        {
            _engine = Engine;          
        }

        public void StartEngine()
        {
            Console.WriteLine(_engine.StartEngine());
        }
    }


}
