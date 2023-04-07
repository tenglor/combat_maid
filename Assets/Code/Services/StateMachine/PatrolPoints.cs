using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolPoints : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Vector3> points;
    private int currentIndex;
    private static float distanceError = 0.1f;

    public void Start()
    {
        currentIndex = 0;
    }

    public bool HasReached() {
        var distance = Vector2.Distance(points[currentIndex], transform.position);
        return distance < distanceError;
    }

    public Vector3 GetNext() {
        currentIndex++;
        currentIndex = (currentIndex == points.Count) ? 0 : currentIndex;
        return points[currentIndex];
    }

    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < points.Count - 1; i++) {
            Gizmos.DrawLine(points[i], points[i+1]);
        }
        Gizmos.DrawLine(points[points.Count - 1], points[0]);
    }

    public Vector2 Direction(){
        Vector2 distance = points[currentIndex] - transform.position;
        distance.Normalize();
        return distance;
    }
}
