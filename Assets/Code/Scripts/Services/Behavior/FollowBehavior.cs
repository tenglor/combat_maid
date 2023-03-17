using UnityEngine;


public class FollowBehavior{

    private Transform _followObject;
    private Transform _transform;

    public FollowBehavior(Transform transform, Transform followObject){
        _transform = transform;
        _followObject  = followObject;
    }

    public Vector2 getDirection(){
        var result = _followObject.position - _transform.position;
        return new Vector2(result.x, result.y);
    }

}