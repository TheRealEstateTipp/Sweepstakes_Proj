using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;


        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack = new Stack<Sweepstakes>();
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            stack = new Stack<Sweepstakes>();
            Sweepstakes sweepstakes = stack.Pop();

            UI.PrintString("The sweepstakes removed from the stack is" + sweepstakes);
            return sweepstakes;
        }
    }
}
