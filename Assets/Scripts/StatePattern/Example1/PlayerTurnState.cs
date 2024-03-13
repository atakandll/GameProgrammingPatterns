namespace StatePattern.Example1
{
    public class PlayerTurnState : AITurnState
    {
        public override bool IsPlayer => true;
        
    }
}