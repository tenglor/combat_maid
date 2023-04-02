using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Services.StateMachine;

public class PlayerController : MonoBehaviour
{

    public LayerMask layerMask;
    public Transform groundCheck;

    public Groudable groudable;
    public IInputService inputService;

    public float attackTimeout;
    private float currentTime;

    private StateMachine stateMachine;

    public List<BaseState> states;

    // Start is called before the first frame update
    void Awake()
    {
        groudable = new Groudable(groundCheck, layerMask);
        inputService = new DesktopInputService();     
    }

    private void Start()
    {
        stateMachine = GetComponent<StateMachine>();
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (inputService.isAttackPressed && currentTime > attackTimeout) {
            foreach(var i in states){
                if(i is PlayerAttack) {
                    currentTime = 0;
                    stateMachine.ChangeState(i);
                    break;
                }
            }
        }
    }

}
