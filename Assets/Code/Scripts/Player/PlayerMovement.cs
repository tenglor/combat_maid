using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IInputService inputService;
    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        inputService = GetComponent<PlayerInit>().inputService;
    }

    // Update is called once per frame
    void Update()
    {
        float speedX = inputService.Axis.x * speed;
        rb.velocity = new Vector2(speedX, rb.velocity.y);
        if (Mathf.Abs(speedX) > 0.01) {
            Vector3 theScale = transform.localScale;
            //зеркально отражаем персонажа по оси Х
            theScale.x = Mathf.Abs(theScale.x) * Mathf.Sign(speedX);
            //задаем новый размер персонажа, равный старому, но зеркально отраженный
            transform.localScale = theScale;
        }
    }
}
