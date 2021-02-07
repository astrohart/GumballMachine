namespace GumballMachine.Interfaces
{
   public interface IGumballMachineActions
   {
      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      void EjectQuarter();

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      void InsertQuarter();

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      void TurnCrank();

      /// <summary>
      /// Refills the gumball machine by adding <paramref name="count" /> more gumballs.
      /// </summary>
      /// <param name="count">
      /// (Required.) An integer that specifies the number of gumballs to add.
      /// </param>
      /// <remarks>
      /// The <paramref name="count" /> parameter must be 1 or higher.
      /// </remarks>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// Thrown if the <paramref name="count" /> parameter is zero or negative.
      /// </exception>
      void Refill(int count);
   }
}