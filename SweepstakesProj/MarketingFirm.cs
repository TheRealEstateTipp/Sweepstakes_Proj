using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
     class MarketingFirm 
    {
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;

            //We have used dependency injection here in the constructor method because this will allow the marketing firm to use Sweepstakes manager,
            //but it also allows the Marketing Firm to choose which type of manager that it would like to use based on the classes that took on the 
            //interface of the ISweepstakesManager, which are SweepstakesQueueManager and the SweepstakesStackManager. The Marketing Firm now can determine
            //if they would like to use the FIFO method with the Queue or the FIFO method with the Stack but it will be their choice.

        }

        public void CreateSweepstake()
        {
            Sweepstakes newSweepstake = new Sweepstakes("newSweepstake");
        }

        
    }

}
