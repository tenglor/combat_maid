using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IInputService _inputService;
    public Rigidbody2D rb;
    public Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        _inputService = new DesktopInputService();
    }

    // Update is called once per frame
    void Update()
    {
        float speedX = _inputService.Axis.x * speed.x;
        rb.velocity = new Vector2(speedX, rb.velocity.y);
    }
}
