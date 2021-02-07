using System.Net.NetworkInformation;

namespace GumballMachine
{
   /// <summary>
   /// Represents a Gumball Machine.
   /// </summary>
   public class GumballMachineContext
   {
      /// <summary>
      /// The machine is out of gumballs.
      /// </summary>
      public const int SOLD_OUT = 0;

      /// <summary>
      /// There is no quarter in the machine.
      /// </summary>
      public const int NO_QUARTER = 1;

      /// <summary>
      /// A quarter has been inserted in the machine.
      /// </summary>
      public const int HAS_QUARTER = 2;

      /// <summary>
      /// A gumball has been dispensed.
      /// </summary>
      public const int SOLD = 3;

      /// <summary>
      /// Entry point of the program.
      /// </summary>
      /// <param name="args">
      /// Collection of arguments passed on the command line of the program.
      /// </param>
      public static void Main(string[] args) { }
   }
}