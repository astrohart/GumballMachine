using System;

namespace GumballMachine
{
   /// <summary>
   /// The machine is out of gumballs.
   /// </summary>
   public class SoldOutState : StateBase
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:GumballMachine.SoldOutState" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public SoldOutState(IGumballMachine machine) : base(machine) { }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
         => Console.WriteLine("No gumball dispensed.");

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
         => Console.WriteLine(
            "You can't eject because you haven't inserted a quarter yet."
         );

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
      {
         Console.WriteLine(
            "You can't insert a quarter because the machine is sold out."
         );
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
         => "Machine is out of gumballs.";

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
      {
         Console.WriteLine(
            "You turned the crank, but there are no gumballs in the machine."
         );
      }
   }
}