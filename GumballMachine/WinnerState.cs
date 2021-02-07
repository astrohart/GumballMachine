using System;

namespace GumballMachine
{
   /// <summary>
   /// We have a winner! You get 2 gumballs instead of 1 -- unless there's only
   /// 1 gumball currently in the machine.
   /// </summary>
   public class WinnerState : SoldState
   {
      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.SoldState" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public WinnerState(IGumballMachine machine) : base(machine) { }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
      {
         Console.WriteLine(
            "You're a winner!  Every 10th customer gets 2 gumballs."
         );
         if (_machine.NumberOfGumballs >= 2)
            _machine
               .ReleaseGumball(); // give the winner a 2nd gumball if there are more available
         base.Dispense();
      }
   }
}