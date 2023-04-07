using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Services.StateMachine;

[CreateAssetMenu(menuName = "FSM/Player/Attack")]
public class PlayerAttack : BaseState
{
    private IInputService inputService;

    public GameObject attackPrefab;
    private GameObject attackObject;
    private Rigidbody2D rb;

    public float speed;

    private float duration;
    private float currentTime;

    public BaseState afterState;    


    public Vector3 offset;
    // Start is called before the first frame update
    public override void Enter(StateMachine stateMachine)
    {
        base.Enter(stateMachine);
        duration = attackPrefab.GetComponent<AttackController>().duration;
        rb = stateMachine.GetComponent<Rigidbody2D>();
        inputService = stateMachine.GetComponent<PlayerController>().inputService;
        currentTime = 0;

        attackObject = GameObject.Instantiate(attackPrefab, stateMachine.transform);
        attackObject.transform.localPosition = offset;
        attackObject.GetComponent<AttackController>().Attack();
    }

    // Update is called once per frame
    public override void UpdateLogic(StateMachine stateMachine)
    {
        base.UpdateLogic(stateMachine);
        currentTime += Time.deltaTime;
        if (currentTime > duration) {
            stateMachine.ChangeState(afterState);
        }
    }

    public override void UpdatePhysics(StateMachine stateMachine) {
        base.UpdatePhysics(stateMachine);
        float speedX = inputService.Axis.x * speed;
        rb.velocity = new Vector2(speedX, rb.velocity.y);
    }

    public override void Exit(StateMachine stateMachine)
    {
        base.Exit(stateMachine);
        Destroy(attackObject);
    }

}
