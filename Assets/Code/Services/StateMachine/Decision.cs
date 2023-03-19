using UnityEngine;

namespace Services.StateMachine
{
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(BaseStateMachine state);
    }
}