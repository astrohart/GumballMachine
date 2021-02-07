namespace GumballMachine
{
   public interface IGumballMachine
   {
      void SetState(IState newState);

      IState GetHasQuarterState();
   }
}