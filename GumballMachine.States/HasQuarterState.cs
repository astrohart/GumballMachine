using GumballMachine.Interfaces;
using System;

namespace GumballMachine.States
{
   /// <summary>
   /// A quarter has been inserted in the machine.
   /// </summary>
   public class HasQuarterState : StateBase
   {
      private readonly Random randomWinnerGenerator = new Random(
         Guid.NewGuid().GetHashCode()
      );

      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.StateBase" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public HasQuarterState(IGumballMachine machine) : base(machine) { }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
         => Console.WriteLine("No gumball dispensed.");

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
      {
         Console.WriteLine("Quarter returned.");
         _machine.SetState(_machine.NoQuarterState);
      }

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
         => Console.WriteLine("You can't insert another quarter.");

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
         => "Machine has a quarter in the slot.";

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
      {
         Console.WriteLine("You turned the crank...");
         var randomWinner = randomWinnerGenerator.Next(10);
         _machine.SetState(
            randomWinner == 0 && _machine.NumberOfGumballs > 1 ? _machine.WinnerState : _machine.SoldState
         );
      }
   }
}