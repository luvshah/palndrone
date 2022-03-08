using UnityEngine;

public class CamFPSCannon : CameraBaseState
{
    public override void EnterState(GyroCam CSM)
    {
        //anchor the view
        CSM.transform.position = CSM.fps_anchor.transform.position;
        CSM.transform.LookAt(CSM.fps_anchor.transform.forward);
    }

    public override void OnCollisionEnter(GyroCam PSM, Collision collision)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(GyroCam PSM)
    {
        
    }
}