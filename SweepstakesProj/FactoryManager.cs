using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
     static class FactoryManager
    {
        public static ISweepstakesManager GetManagerType (string type)
        {
            ISweepstakesManager manager = null;
            switch(type)
            {
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;

                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;
                default:
                    UI.PrintString("This type is not valid");
                    break;
            }
            return manager;
        }

    }
}
