
using UnityEngine;

public class PlayerCannonState : PlayerBaseState
{
    
    public override void EnterState(PlayerStateManager PSM)
    {
        Debug.Log("CannonState.Enter");
       
    }

    public override void OnCollisionEnter(PlayerStateManager PSM, Collision collision)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateManager PSM)
    {
        
    }

}
