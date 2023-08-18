namespace _GAME_.Script.PlayerController.State
{
    public abstract class PlayerState
    {
        protected readonly PlayerMachine PlayerMachine;
        
        protected PlayerState(PlayerMachine playerMachine)
        {
            PlayerMachine = playerMachine;
        }
        
        public abstract void Enter();

        public abstract void Tick();

        public abstract void FixedTick();

        public abstract void Exit();
    } 
}
