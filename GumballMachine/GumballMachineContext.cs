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
               "ERROR: Cannot load zero or a negative number of gumballs into the machine."
            );
      }

      /// <summary>
      /// Gets the count of gumballs.
      /// </summary>
      public int Count { get; }

      /// <summary>
      /// Gets or sets the current state.
      /// </summary>
      public int State { get; private set; } = SOLD_OUT;

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
               Console.WriteLine(
                  "Sorry!  You already turned the crank."
               );
               break;
         }
      }
   }
}