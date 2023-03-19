using UnityEngine;

namespace Services.StateMachine
{
    public class BaseState : ScriptableObject
    {
        public virtual void Execute(BaseStateMachine machine) { }
    }
}