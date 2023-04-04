using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Code.Services.StateMachine;

[CreateAssetMenu(menuName = "FSM/Player/Movement")]
public class PlayerMovement : BaseState
{
    private IInputService inputService;
    private Rigidbody2D rb;
    public float speed;

    public override void Enter(StateMachine stateMachine)
    {
        rb = stateMachine.GetComponent<Rigidbody2D>();
        inputService = stateMachine.GetComponent<PlayerController>().inputService;
    }

    // Update is called once per frame
    public override void UpdatePhysics(StateMachine stateMachine)
    {
        float speedX = inputService.Axis.x * speed;
        rb.velocity = new Vector2(speedX, rb.velocity.y);
        if (Mathf.Abs(speedX) > 0.01)
        {
            Vector3 theScale = rb.transform.localScale;
            //зеркально отражаем персонажа по оси Х
            theScale.x = Mathf.Abs(theScale.x) * Mathf.Sign(speedX);
            //задаем новый размер персонажа, равный старому, но зеркально отраженный
            rb.transform.localScale = theScale;
        }
    }
}
