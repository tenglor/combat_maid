using UnityEngine;

public interface IInputService
{
    public Vector2 Axis { get; }
    public bool isJumpPressed{ get; }

    public bool isAttackPressed { get; }
    
}