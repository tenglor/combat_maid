using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Services.StateMachine
{
    [CreateAssetMenu(menuName = "FSM/Decisions/PlayerInView")]
    class DetectPlayerDecision : Decision
    {
        public float detectRadius = 1f;
        
        public override bool Decide(BaseStateMachine state)
        {
            Vector2 playerPos = GameObject.FindGameObjectWithTag("player").transform.position;
            Vector2 objPosition = state.transform.position;
            
            return Vector2.Distance(playerPos, objPosition) < 1f;
        }
    }
}
