using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryPattern.Example1
{
    #region Product
    public abstract class AIBase
    {
        public abstract string Move { get; }
        public void DoMove() => Debug.Log("My AI Move is: " + Move);

    }
    
    #endregion

    #region Concrete Products

    public class AIRandom : AIBase
    {
        const string Attack = "Attack";
        const string Heal = "Heal";
        public override string Move => Random.Range(0f, 1f) > 0.5f ? Attack : Heal;
    }

    public class AIHeal : AIBase
    {
        public override string Move => "Heal!!";
        
    }

    public class AIAttack : AIBase
    {
        public override string Move => "Attack!!";
    }

    #endregion
    
    public enum AiArchetype
    {
        Random,
        Heal,
        Attack
    }

    #region Factory

    public abstract class AIBaseFactory
    {
        public abstract AIBase CreateAI(AiArchetype aiArchetype);
        public abstract AIBase CreateRandom();
    }

    #endregion

    #region Concrete Factory

    public class AIFactory : AIBaseFactory
    {
       
        public override AIBase CreateAI(AiArchetype aiArchetype)
        {
            switch (aiArchetype)
            {
                case AiArchetype.Attack: return new AIAttack();
                case AiArchetype.Heal: return new AIHeal();
                case AiArchetype.Random: return new AIRandom();
                default:  throw new ArgumentOutOfRangeException(nameof( aiArchetype),  aiArchetype, null);
                
            }
        }

        public override AIBase CreateRandom()
        {
           var ais = new[] {AiArchetype.Attack, AiArchetype.Heal, AiArchetype.Random};
           var index = Random.Range(0, 3);
           return CreateAI(ais[index]);
        }
    }

    #endregion
   
}