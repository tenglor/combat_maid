using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInit : MonoBehaviour
{

    public LayerMask layerMask;
    public Transform groundCheck;

    public Groudable groudable;
    public IInputService inputService;
    // Start is called before the first frame update
    void Awake()
    {
        groudable = new Groudable(groundCheck, layerMask);
        inputService = new DesktopInputService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
