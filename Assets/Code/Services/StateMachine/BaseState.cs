using UnityEngine;

namespace Services.StateMachine
{
    public class BaseState : ScriptableObject
    {
        [HideInInspector]

        public virtual void Enter(StateMachine stateMachine) { }
        public virtual void UpdateLogic(StateMachine stateMachine) { }
        public virtual void UpdatePhysics(StateMachine stateMachine) { }
        public virtual void Exit(StateMachine stateMachine) { }

        public virtual void Draw(StateMachine stateMachine) { }
    }
}