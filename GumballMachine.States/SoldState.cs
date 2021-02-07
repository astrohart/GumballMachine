using GumballMachine.Interfaces;
using System;

namespace GumballMachine.States
{
   /// <summary>
   /// A gumball has been dispensed.
   /// </summary>
   public class SoldState : StateBase
   {
      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.SoldState" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public SoldState(IGumballMachine machine) : base(machine) { }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
      {
         _machine.ReleaseGumball();
         if (_machine.NumberOfGumballs > 0)
         {
            _machine.SetState(_machine.NoQuarterState);
         }
         else
         {
            Console.WriteLine("Oops!  We've run out of gumballs!");
            _machine.SetState(_machine.SoldOutState);
         }
      }

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
         => Console.WriteLine("Sorry, you already turned the crank.");

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
         => Console.WriteLine("Please wait.  We're already giving you a gumball.");

      /// <summary>
      /// Refills the machine with more gumballs.
      /// </summary>
      public override void Refill() { }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
         => "Machine dispensed a gumball.";

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
         => Console.WriteLine("Turning twice doesn't get you another gumball!");
   }
}