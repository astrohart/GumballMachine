using NUnit.Framework;
using System;

namespace GumballMachine.Tests
{
   /// <summary>
   /// Provides unit tests.
   /// </summary>
   [TestFixture]
   public class GumballMachineContextTests
   {
      /// <summary>
      /// Asserts that the gumball machine works for normal use cases.
      /// </summary>
      [Test]
      public void Test_GumballMachine_WorksAsExpected_ForNormalUse()
      {
         const int INITIAL_GUMBALL_AMOUNT = 5;

         // create a new gumball machine loaded with INITIAL_GUMBALL_AMOUNT gumballs.
         var machine = new GumballMachineContext(INITIAL_GUMBALL_AMOUNT);

         Console.WriteLine(machine); // print out the state of the machine

         machine.InsertQuarter(); // throw a quarter in...
         machine.TurnCrank(); // turn the crank; we should get one gumball.

         // since we inserted a quarter and then turned the crank, we expect
         // that the machine has one less gumball than we loaded it with
         Assert.IsTrue(machine.NumberOfGumballs == INITIAL_GUMBALL_AMOUNT - 1);

         Console.WriteLine(machine); // print out the state of the machine again

         machine.InsertQuarter(); // throw a quarter in...
         machine.EjectQuarter(); // ask for it back
         machine.TurnCrank(); // turn he crank; we shouldn't get a gumball

         // should still have INITIAL_GUMBALL_COUNT - 1 gumballs in the machine
         Assert.IsTrue(machine.NumberOfGumballs == INITIAL_GUMBALL_AMOUNT - 1);

         Console.WriteLine(machine); // print out the state of the machine again

         machine.InsertQuarter(); // throw a quarter in...
         machine.TurnCrank(); // turn the crank; we should get one gumball.
         machine.InsertQuarter(); // throw a quarter in...
         machine.TurnCrank(); // turn the crank; we should get one gumball.
         machine.EjectQuarter(); // ask for a quarter back that we didn't put in.

         // should now have even less gumballs (by two more) than we started
         // with prior to the most recently run group of tests
         Assert.IsTrue(machine.NumberOfGumballs == INITIAL_GUMBALL_AMOUNT - 3);

         Console.WriteLine(machine); // print out the state of the machine again

         machine.InsertQuarter(); // throw TWO quarters in...
         machine.InsertQuarter();
         machine.TurnCrank(); // turn the crank; we should get one gumball.
         machine.InsertQuarter();
         machine.TurnCrank(); // now for the stress test :-)
         machine.InsertQuarter();
         machine.TurnCrank();

         Assert.IsTrue(
            machine.NumberOfGumballs <= 0
         ); // assert that machine is out of inventory

         Console.WriteLine(machine); // print that machine state one more time
      }
   }
}