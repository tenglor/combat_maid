using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Services.StateMachine
{
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] private BaseState _initialState;

        private void Start()
        {
            CurrentState = _initialState;     
            CurrentState.Enter(this);
        }

        public BaseState CurrentState { get; set; }

        private void FixedUpdate()
        {
            CurrentState.UpdatePhysics(this);
        }

        private void Update()
        {
            CurrentState.UpdateLogic(this);
        }

        public void ChangeState(BaseState newState) 
        {
            CurrentState.Exit(this);

            CurrentState = newState;
            CurrentState.Enter(this);
        }
        
    }
}
