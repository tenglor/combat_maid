using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Code.Services.StateMachine
{
    [CreateAssetMenu(menuName = "FSM/Patrol")]
    class PatrolState : BaseState
    {
        private PatrolPoints patrolPoints;
        private Rigidbody2D rb;
        private Vector3 currentDestination;

        public float speed;
        public override void Enter(StateMachine stateMachine)
        {
            base.Enter(stateMachine);
            patrolPoints = stateMachine.GetComponent<PatrolPoints>();
            rb = stateMachine.GetComponent<Rigidbody2D>();
            currentDestination = patrolPoints.points[0];
        }

        public override void UpdatePhysics(StateMachine stateMachine)
        {
            base.UpdatePhysics(stateMachine);
            Vector2 direction = patrolPoints.Direction();
            rb.velocity = new Vector2(direction.x * speed, direction.y * speed); 
        }

        public override void UpdateLogic(StateMachine stateMachine)
        {
            base.UpdateLogic(stateMachine);
            if(patrolPoints.HasReached()){
                currentDestination = patrolPoints.GetNext();
            }
        }

    }
}
