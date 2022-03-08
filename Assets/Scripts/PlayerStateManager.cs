using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateManager : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerBaseState currentState;
    public PlayerCannonState cannonState = new PlayerCannonState();
    public PlayerRocketState rocketState = new PlayerRocketState();
    public PlayerMortarState mortarState = new PlayerMortarState();


    //
    [SerializeField] private PlayerInput playercontroller;
    private CharacterController CharacterControllerTank;
    public GameObject cannonBallPrefab;
   // public GameObject rocketPrefab;
    //public GameObject mortarshellPrefab;
    public Transform projectileSpawnPoint;

    void Start()
    {
        Debug.Log("PSM -> Cannon State");
        currentState = cannonState;
        currentState.EnterState(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public  void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);

    }
}
