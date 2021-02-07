using System;

namespace GumballMachine
{
   /// <summary>
   /// A quarter has been inserted in the machine.
   /// </summary>
   public class HasQuarterState : StateBase
   {
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
         => throw new NotImplementedException();

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
         => throw new NotImplementedException();

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
         => throw new NotImplementedException();

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
         => throw new NotImplementedException();
   }
}