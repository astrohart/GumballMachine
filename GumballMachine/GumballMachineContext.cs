using GumballMachine.Properties;
using System;

namespace GumballMachine
{
   /// <summary>
   /// Represents a Gumball Machine.
   /// </summary>
   public class GumballMachineContext : IGumballMachine
   {
      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:GumballMachine.GumballMachineContext" />
      /// and returns a
      /// reference to it.
      /// </summary>
      /// <param name="numberOfGumballs">
      /// (Required.) Integer that specifies how many gumballs to initially fill
      /// the machine with.
      /// </param>
      public GumballMachineContext(int numberOfGumballs)
      {
         HasQuarterState = new HasQuarterState(this);
         NoQuarterState = new NoQuarterState(this);
         SoldState = new SoldState(this);
         SoldOutState = new SoldOutState(this);
         WinnerState = new WinnerState(this);

         NumberOfGumballs = numberOfGumballs;
         CurrentState = numberOfGumballs > 0 ? NoQuarterState : SoldOutState;
      }

      /// <summary>
      /// Gets the current state.
      /// </summary>
      public IState CurrentState { get; private set; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine has a quarter inserted in its slot.
      /// </summary>
      public IState HasQuarterState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine does not have a quarter inserted in its slot.
      /// </summary>
      public IState NoQuarterState { get; }

      /// <summary>
      /// Gets the count of gumballs.
      /// </summary>
      public int NumberOfGumballs { get; private set; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine is out of gumballs.
      /// </summary>
      public IState SoldOutState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the machine is to dispense a purchased gumball.
      /// </summary>
      public IState SoldState { get; }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the customer deserves 2 gumballs because they have won the
      /// 1-in-10 game, where every 10th customer gets 2 gumballs.
      /// </summary>
      public IState WinnerState { get; }

      /// <summary>
      /// Performs the action of releasing the gumball for the purchaser and
      /// updating our inventory.
      /// </summary>
      public void ReleaseGumball()
      {
         Console.WriteLine("A gumball comes rolling out of the slot...");
         if (NumberOfGumballs > 0) NumberOfGumballs--;
      }

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
      public void SetState(IState newState)
         => CurrentState = newState ??
                           throw new ArgumentNullException(nameof(newState));

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public void EjectQuarter()
         => CurrentState?.EjectQuarter();

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public void InsertQuarter()
         => CurrentState?.InsertQuarter();

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
      public void Refill(int count)
      {
         if (count <= 0)
            throw new ArgumentOutOfRangeException(
               Resources.Error_CountMustBePositive
            );

         NumberOfGumballs += count;

         if (CurrentState == SoldOutState)
            SetState(
               NoQuarterState
            ); // reset machine to allow getting gumballs again

         Console.WriteLine(
            $"Gumball machine refilled.  Inventory: {NumberOfGumballs} gumballs."
         );
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
      {
         var result = string.Empty;

         result = Environment.NewLine;
         result += "Mighty Gumball, Inc." + Environment.NewLine;
         result += "C#-enabled Standing Gumball Model #2021" +
                   Environment.NewLine;
         result += $"Inventory: {NumberOfGumballs} gumballs" +
                   Environment.NewLine + CurrentState;

         result += Environment.NewLine;
         return result;
      }

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public void TurnCrank()
      {
         CurrentState?.TurnCrank();
         CurrentState?.Dispense();
      }
   }
}