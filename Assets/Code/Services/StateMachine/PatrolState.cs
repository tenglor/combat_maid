//using Services.StateMachine.Enemy;
//using Services.StateMachine.FSM;
using UnityEngine;
using UnityEngine.AI;

namespace Services.StateMachine
{
    [CreateAssetMenu(menuName = "FSM/Actions/Patrol")]
    public class PatrolAction : SMAction
    {
        public override void Execute(BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            //var patrolPoints = stateMachine.GetComponent<PatrolPoints>();

            // if (patrolPoints.HasReached(navMeshAgent))
            //     navMeshAgent.SetDestination(patrolPoints.GetNext().position);
        }
    }
}