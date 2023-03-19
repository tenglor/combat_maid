using UnityEngine;

namespace Services.StateMachine
{
    public abstract class SMAction : ScriptableObject
    {
        public abstract void Execute(BaseStateMachine stateMachine);
    }
}