using GumballMachine.Interfaces;

namespace GumballMachine
{
   public static class GumballMachineFactory
   {
      public static IGumballMachineActions Make(int numberOfGumballs, bool gamified = true)
         => gamified
            ? new GamifiedGumballMachineContext(numberOfGumballs)
            : new GumballMachineContext(numberOfGumballs);
   }
}