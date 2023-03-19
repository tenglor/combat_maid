using UnityEngine;

public class Groudable{

    private LayerMask whatIsGround;
    public Transform groundCheckPoint;
    public const float groundRadius = 0.1f;


    public Groudable(Transform groundCheckPoint, LayerMask whatIsGround){
        this.groundCheckPoint = groundCheckPoint;
        this.whatIsGround = whatIsGround;
    }

    public bool onGround {
        get{ 
            return Physics2D.OverlapCircle(groundCheckPoint.position, groundRadius, whatIsGround);
        }
    }
}