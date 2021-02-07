using System;

namespace GumballMachine
{
   /// <summary>
   /// There is no quarter in the machine.
   /// </summary>
   public class NoQuarterState : StateBase
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:GumballMachine.NoQuarterState" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public NoQuarterState(IGumballMachine machine) : base(machine) { }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
         => Console.WriteLine("You need to pay first!");

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
         => Console.WriteLine("You haven't inserted a quarter.");

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
      {
         Console.WriteLine("You inserted a quarter.");
         _machine.SetState(_machine.HasQuarterState);
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
         => "Machine is waiting for a quarter to be inserted.";

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
         => Console.WriteLine("You turned the crank but there is no quarter.");
   }
}