using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private FollowBehavior followBehavior;
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
    }
}
