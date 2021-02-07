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
      public const int HAS_QUARTER = 2;

      /// <summary>
      /// There is no quarter in the machine.
      /// </summary>
      public const int NO_QUARTER = 1;

      /// <summary>
      /// A gumball has been dispensed.
      /// </summary>
      public const int SOLD = 3;

      /// <summary>
      /// The machine is out of gumballs.
      /// </summary>
      public const int SOLD_OUT = 0;

      /// <summary>
      /// Gets or sets the current state.
      /// </summary>
      public int State { get; set; }

      /// <summary>
      /// Entry point of the program.
      /// </summary>
      public static void Main() { }
   }
}