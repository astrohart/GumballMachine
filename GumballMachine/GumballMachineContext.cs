﻿using System;

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
      public static void Main()
      {
         // TODO: Add the program's statements here.

         Console.ReadKey();
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
               ;

            case SOLD: // A gumball was dispensed.
               Console.WriteLine(
                  "Please wait.  We're already giving you a gumball."
               );
               break;
         }
      }
   }
}

}