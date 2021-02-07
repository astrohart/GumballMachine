namespace GumballMachine
{
   /// <summary>
   /// Defines the behaviors of the gumball machine when it's in a given state.
   /// </summary>
   public interface IState
   {
      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      void InsertQuarter();

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      void EjectQuarter();

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      void TurnCrank();

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      void Dispense();
   }
}