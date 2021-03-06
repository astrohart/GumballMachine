using GumballMachine.States.Interfaces;

namespace GumballMachine.Interfaces
{
   /// <summary>
   /// Defines the public-exposed methods and properties of a gumball machine.
   /// </summary>
   public interface IGumballMachine
   {
      /// <summary>
      /// Gets the current state.
      /// </summary>
      IState CurrentState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine has a quarter inserted in its slot.
      /// </summary>
      IState HasQuarterState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine does not have a quarter inserted in its slot.
      /// </summary>
      IState NoQuarterState { get; }

      /// <summary>
      /// Gets the count of gumballs.
      /// </summary>
      int NumberOfGumballs { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine is out of gumballs.
      /// </summary>
      IState SoldOutState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine is to dispense a purchased gumball.
      /// </summary>
      IState SoldState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the customer deserves 2 gumballs because they have won the
      /// 1-in-10 game, where every 10th customer gets 2 gumballs.
      /// </summary>
      IState WinnerState { get; }

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

      /// <summary>
      /// Performs the action of releasing the gumball for the purchaser and
      /// updating our inventory.
      /// </summary>
      void ReleaseGumball();

      /// <summary>
      /// Transitions the gumball machine to the new state.
      /// </summary>
      /// <param name="state">
      /// (Required.) Reference to an instance of an object that implements the
      /// <see cref="T:GumballMachine.IState" /> interface that represents the
      /// new state of the machine.
      /// </param>
      /// <exception cref="T:System.ArgumentNullException">
      /// Thrown if the required parameter, <paramref name="newState" />, is
      /// passed a <c>null</c> value.
      /// </exception>
      void SetState(IState newState);
   }
}