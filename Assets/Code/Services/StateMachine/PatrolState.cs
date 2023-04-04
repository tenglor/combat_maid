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
        public override void Enter(StateMachine stateMachine)
        {
            base.Enter(stateMachine);
            patrolPoints = stateMachine.GetComponent<PatrolPoints>();

        }

        public override void UpdatePhysics(StateMachine stateMachine)
        {
            base.UpdatePhysics(stateMachine);
        }

        public override void UpdateLogic(StateMachine stateMachine)
        {
            base.UpdateLogic(stateMachine);
        }

        public override void Draw(StateMachine stateMachine)
        {
            base.Draw(stateMachine);
            for (int i = 0; i < patrolPoints.points.Count - 1; i++)
            {
                Gizmos.DrawLine(patrolPoints.points[i], patrolPoints.points[i + 1]);
            }
            Gizmos.DrawLine(patrolPoints.points[patrolPoints.points.Count - 1], patrolPoints.points[0]);
        }
    }
}
