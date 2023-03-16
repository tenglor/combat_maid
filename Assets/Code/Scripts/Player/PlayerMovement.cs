using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IInputService inputService;
    public Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        inputService = new DesktopInputService();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 add;

        add.x = inputService.Axis.x * Time.deltaTime * speed.x;
        add.y = inputService.Axis.y * Time.deltaTime * speed.y;
        add.z = 0;
        transform.position += add;
        //float speedX = _inputService.Axis.x * Speed;
        //rb.velocity = new Vector2(speedX, rb.velocity.y);
    }
}
