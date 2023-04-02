using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    // Start is called before the first frame update
    public float AttackRange;
    public LayerMask DamageableLayerMask;
    public float duration;
    public SpriteRenderer sprite;

    private IEnumerator AttackCorountime() {
        sprite.enabled = true;
        yield return new WaitForSeconds(duration);
        sprite.enabled = false;
    }

    // Update is called once per frame
    public void Attack() {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange, DamageableLayerMask);
        StartCoroutine(AttackCorountime());
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }
}
