using GumballMachine.Properties;
using System;

namespace GumballMachine
{
   /// <summary>
   /// Represents a Gumball Machine.
   /// </summary>
   public class GumballMachineContext
   {
      /// <summary>
      /// A quarter has been inserted in the machine.
      /// </summary>
      private const int HAS_QUARTER = 2;

      /// <summary>
      /// There is no quarter in the machine.
      /// </summary>
      private const int NO_QUARTER = 1;

      /// <summary>
      /// A gumball has been dispensed.
      /// </summary>
      private const int SOLD = 3;

      /// <summary>
      /// The machine is out of gumballs.
      /// </summary>
      private const int SOLD_OUT = 0;

      /// <summary>
      /// Constructs a new instance of
      /// <see
      ///    cref="T:GumballMachine.GumballMachineContext" />
      /// and returns a
      /// reference to it.
      /// </summary>
      /// <param name="count">
      /// (Required.) Integer that specifies how many gumballs to initially fill
      /// the machine with.
      /// </param>
      public GumballMachineContext(int count)
      {
         Count = count;
         if (count > 0)
            State = NO_QUARTER;
         else
            throw new ArgumentOutOfRangeException(
               Resources.Error_CountMustBePositive
            );
      }

      /// <summary>
      /// Gets the count of gumballs.
      /// </summary>
      public int Count { get; private set; }

      /// <summary>
      /// Gets or sets the current state.
      /// </summary>
      public int State { get; private set; }

      /// <summary>
      /// Ejects a quarter from the gumball machine.
      /// </summary>
      public void EjectQuarter()
      {
         switch (State)
         {
            case HAS_QUARTER: // There already is a quarter in the machine.
               Console.WriteLine("Quarter returned.");
               State = NO_QUARTER;
               break;

            case NO_QUARTER: // A quarter isn't in the machine.
               Console.WriteLine("You haven't inserted a quarter.");
               break;

            case SOLD_OUT: // No more gumballs are left.
               Console.WriteLine(
                  "You can't eject because you haven't inserted a quarter yet."
               );
               break;

            case SOLD: // A gumball was dispensed.
               Console.WriteLine("Sorry!  You already turned the crank.");
               break;
         }
      }

      /// <summary>
      /// Inserts a quarter into the gumball machine.
      /// </summary>
      public void InsertQuarter()
      {
         switch (State)
         {
            case HAS_QUARTER: // There already is a quarter in the machine.
               Console.WriteLine("You can't insert another quarter.");
               break;

            case NO_QUARTER: // A quarter isn't in the machine.
               State = HAS_QUARTER;
               Console.WriteLine("You inserted a quarter.");
               break;

            case SOLD_OUT: // No more gumballs are left.
               Console.WriteLine(
                  "You can't insert a quarter because the machine is sold out."
               );
               break;

            case SOLD: // A gumball was dispensed.
               Console.WriteLine(
                  "Please wait.  We're already giving you a gumball."
               );
               break;
         }
      }

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

         Count += count;
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>
      /// A string that represents the current object.
      /// </returns>
      public override string ToString()
         => $"Gumball machine has {Count} gumballs.";

      /// <summary>
      /// Turns the crank of the gumball machine.
      /// </summary>
      public void TurnCrank()
      {
         switch (State)
         {
            case HAS_QUARTER: // There already is a quarter in the machine.
               Console.WriteLine("You turned the crank, so you get a gumball.");
               State = SOLD;
               Dispense();
               break;

            case NO_QUARTER: // A quarter isn't in the machine.
               Console.WriteLine(
                  "You turned the crank but there is no quarter."
               );
               break;

            case SOLD_OUT: // No more gumballs are left.
               Console.WriteLine(
                  "You turned the crank, but there are no gumballs in the machine."
               );
               break;

            case SOLD: // A gumball was dispensed.
               Console.WriteLine(
                  "Turning the crank twice doesn't get you another gumball."
               );
               break;
         }
      }

      /// <summary>
      /// Called to dispense a gumball.
      /// </summary>
      private void Dispense()
      {
         switch (State)
         {
            case HAS_QUARTER: // There already is a quarter in the machine.
               Console.WriteLine("Quarter returned.");
               State = NO_QUARTER;
               break;

            case NO_QUARTER: // A quarter isn't in the machine.
               Console.WriteLine("You need to turn the crank.");
               break;

            case SOLD_OUT: // No more gumballs are left.
               Console.WriteLine("No gumball dispensed.");
               break;

            case SOLD: // A gumball was dispensed.
               Console.WriteLine("A gumball comes rolling out the slot!");
               if (Count == 0)
               {
                  Console.WriteLine("Oops!  We've run out of gumballs!");
                  State = SOLD_OUT;
               }
               else
               {
                  State = NO_QUARTER;
               }

               break;
         }
      }
   }
}