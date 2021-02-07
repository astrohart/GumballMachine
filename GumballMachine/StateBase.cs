namespace GumballMachine
{
   /// <summary>
   /// Implements behavior common to all states.
   /// </summary>
   public abstract class StateBase : IState
   {
      protected IGumballMachine _machine;

      /// <summary>
      /// Constructs a new instance of <see cref="T:GumballMachine.StateBase" />
      /// and returns a reference to it.
      /// </summary>
      /// <param name="machine">
      /// Reference to a <see cref="T:GumballMachine.IGumballMachine" /> that
      /// represents the gumball machine apparatus.
      /// </param>
      protected StateBase(IGumballMachine machine)
      {
         _machine = machine;
      }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      public abstract void Dispense();

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public abstract void EjectQuarter();

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public abstract void InsertQuarter();

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public abstract void TurnCrank();
   }
}