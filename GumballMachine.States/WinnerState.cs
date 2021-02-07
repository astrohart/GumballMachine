using GumballMachine.Interfaces;
using System;

namespace GumballMachine.States
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
         _machine.ReleaseGumball();
         if (_machine.NumberOfGumballs == 0)
         {
            _machine.SetState(_machine.SoldOutState);
         }
         else if (_machine.NumberOfGumballs > 0)
         {
            _machine.ReleaseGumball();
            Console.WriteLine(
               "YOU'RE A WINNER! You got two gumballs for your quarter."
            );
            _machine.SetState(
               _machine.NumberOfGumballs > 0
                  ? _machine.NoQuarterState
                  : _machine.SoldOutState
            );
         }
      }
   }
}