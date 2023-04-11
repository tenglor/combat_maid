using UnityEngine;

public class DesktopInputService : IInputService
{
    public const string Horisontal = "Horizontal";
    public const string Vertical = "Vertical";
    public const KeyCode jumpButton = KeyCode.Space;
    public const KeyCode attackButton = KeyCode.Z;

    public Vector2 Axis => SetDesktopAxis();

    private Vector2 SetDesktopAxis() => 
        new Vector2(UnityEngine.Input.GetAxis(Horisontal), UnityEngine.Input.GetAxis(Vertical));

    public bool isJumpPressed => UnityEngine.Input.GetKey(jumpButton);

    public bool isAttackPressed => UnityEngine.Input.GetKeyDown(attackButton);
}