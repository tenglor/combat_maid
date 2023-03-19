using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public int jumpCharges;
    public float jumpPower;

    private IInputService inputService;
    private Groudable groudable;
    public int currentJumpCharges;

    private bool wasGround;
    private bool onGround;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        inputService = GetComponent<PlayerInit>().inputService;
        groudable = GetComponent<PlayerInit>().groudable;
        onGround = groudable.onGround;
    }

    void FixedUpdate(){
        wasGround = onGround;
        onGround = groudable.onGround;
        if(!wasGround && onGround){
            currentJumpCharges = jumpCharges;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inputService.isJumpPressed && currentJumpCharges > 0){
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            currentJumpCharges--;
        }
    }

    private void OnDrawGizmosSelected() {
        //Gizmos.DrawWireSphere(groudable.groundCheckPoint.position, Groudable.groundRadius);
    }
}
