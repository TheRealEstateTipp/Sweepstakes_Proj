using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public class Sweepstakes
    {
        public string name;
        Dictionary<int, Contestant> sweepstakes;




        public Sweepstakes(string name)
        {
            this.name = name;
            sweepstakes = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {

            UI.PrintString("Please provide your information below to register for the" + name);
            contestant.firstName = UI.GetUserInput("Please enter your first name");
            contestant.lastName = UI.GetUserInput("Please enter your last name");
            contestant.email = UI.GetUserInput("Please provide your email address");
            contestant.registrationNumber = sweepstakes.Count;

            sweepstakes.Add(sweepstakes.Count, contestant);
        }
        public void PickWinner()
        {
            Random random = new Random();
            int index = random.Next(sweepstakes.Count);

            KeyValuePair<int, Contestant> Winner = sweepstakes.ElementAt(index);

            UI.PrintString("The Winner of the" + name + "is" + Winner.Value.firstName + Winner.Value.lastName);
        }

    }
}
