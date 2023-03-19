using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private FollowBehavior followBehavior;
    public Rigidbody2D rb;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        followBehavior = new FollowBehavior(transform, player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = followBehavior.getDirection();
        direction *= Time.deltaTime * speed;
        Vector3 add = new Vector3(direction.x, direction.y, 0);
        transform.position += add;

        if (Mathf.Abs(direction.x) > 0.01) {
            Vector3 theScale = transform.localScale;
            //зеркально отражаем персонажа по оси Х
            theScale.x = Mathf.Abs(theScale.x) * Mathf.Sign(direction.x);
            //задаем новый размер персонажа, равный старому, но зеркально отраженный
            transform.localScale = theScale;
        }
    }
}
