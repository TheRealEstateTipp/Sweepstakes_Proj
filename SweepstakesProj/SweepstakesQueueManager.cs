using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue = new Queue<Sweepstakes>();
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            queue = new Queue<Sweepstakes>();
            Sweepstakes sweepstakes = queue.Dequeue();

            UI.PrintString("The sweepstake to be removed from the queue is" + sweepstakes);
            return sweepstakes;
        }


    }
}
