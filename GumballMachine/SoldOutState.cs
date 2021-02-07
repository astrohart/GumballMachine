using System;

namespace GumballMachine
{
   /// <summary>
   /// The machine is out of gumballs.
   /// </summary>
   public class SoldOutState : StateBase
   {
      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.SoldOutState" />
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