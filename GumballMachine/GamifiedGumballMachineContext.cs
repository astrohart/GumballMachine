using GumballMachine.States;
using GumballMachine.States.Interfaces;

namespace GumballMachine
{
   /// <summary>
   /// Represents a gumball machine that is gamified to give 1 out of every 10
   /// users an extra gumball.
   /// </summary>
   public class GamifiedGumballMachineContext : GumballMachineContext
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
      public GamifiedGumballMachineContext(int numberOfGumballs) : base(
         numberOfGumballs
      )
      {
         WinnerState = new WinnerState(this);
      }

      /// <summary>
      /// Gets a reference to an instance of an object that implements the
      /// <see
      ///    cref="T:GumballMachine.IState" />
      /// interface that defines the behaviors
      /// when the customer deserves 2 gumballs because they have won the
      /// 1-in-10 game, where every 10th customer gets 2 gumballs.
      /// </summary>
      public override IState WinnerState { get; }
   }
}