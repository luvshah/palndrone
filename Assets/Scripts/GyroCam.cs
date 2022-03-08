using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class GyroCam : MonoBehaviour
{
  
    public Transform Body;
    public GameObject fps_anchor;
    public GameObject tps_anchor;

   //public PlayerInput input;
    public float sensitivitiy = 100.0f;
    public float xrot = 0f;
    public Vector3 camrot;
   // public PlayerControl inputactions;
    public bool isFPS = true;
    public int battery = 100;
    public float distanceToTank = 50;
    public bool isTeathered = true;
    
    public CameraBaseState currentcamState;
    public CamFPSCannon C_FC = new CamFPSCannon();
   
    //drone tps mode
      public CamTPSCannon C_TC = new CamTPSCannon();
    //public CamRocketState C_RocketState = new CamRocketState();
    //public CamMortarState C_MortarState = new CamMortarState();
    //public CamUnhookedState C_UnhookedState = new CamUnhookedState();
    //public CamDisabledState C_DisabledState = new CamDisabledState();

    private void ToggleCamPosition()
    {
        Debug.Log("Switching camera view");
      
    }

    private void Awake()
    {
        //input = GetComponent<PlayerInput>();
        //inputactions = new PlayerControl();
        //inputactions.Player.Toggle.performed += contex => ToggleCamPosition();
    }

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
       // inputactions.Enable();
        camrot = transform.localRotation.eulerAngles;
        Debug.Log("FPS cam State");
        currentcamState = C_FC;
        currentcamState.EnterState(this);
        fps_anchor = GameObject.FindGameObjectWithTag("FPS_cam_anchor");
        tps_anchor = GameObject.FindGameObjectWithTag("TPS_cam_anchor");
    }

    // Update is called once per frame
    void Update()
    {
        //float v = -Input.gyro.rotationRateUnbiased.x;
        //camrot.x += v;
        //Vector2 inputmove = input.actions["Look"].ReadValue<Vector2>();
        //mc.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
        //this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
        // float lookx = -Input.gyro.rotationRateUnbiased.x;
        //float looky = -Input.gyro.rotationRateUnbiased.y;

        // xrot -= looky;


        //transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
        //xrot = Mathf.Clamp(xrot, -90f, 90f);
        //this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x - inputmove.y, 0f, 0f);
        //Body.Rotate(0f,-Input.gyro.rotationRateUnbiased.y + inputmove.x,0f);

        //check state
        currentcamState.UpdateState(this);

        //brakeys FPS TUT
      
    }
    public void SwitchState(CameraBaseState state)
    {
        currentcamState = state;
        state.EnterState(this);
    }
}
