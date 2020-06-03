using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            //1. Get user input for either stack or queue
            //2. Pass that input into the factory method
            //3. instantiate MarketingFirm while passing in ISweepstakesManager object that was chosen

            string input = UI.GetManagerType();
            ISweepstakesManager manager = FactoryManager.GetManagerType(input);
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
