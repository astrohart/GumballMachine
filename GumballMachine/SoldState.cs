namespace GumballMachine
{
   /// <summary>
   /// A gumball has been dispensed.
   /// </summary>
   public class SoldState : StateBase
   {
      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public override void Dispense()
         => throw new System.NotImplementedException();

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public override void EjectQuarter()
         => throw new System.NotImplementedException();

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public override void InsertQuarter()
         => throw new System.NotImplementedException();

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public override void TurnCrank()
         => throw new System.NotImplementedException();

      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.SoldState" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      public SoldState(IGumballMachine machine) : base(machine) { }
   }
}