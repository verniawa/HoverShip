using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public GameObject trigger;
    float distanceToGround;
    Rigidbody rigidbody;
    public Transform shipBody;
    public float thrust;
    public float topSpeed;
    public float handling, bodyRotation, pitchRotation;
    float x, y, z;
    Vector3 startPos;
    Quaternion startRot;
    PlayerControls controls;
    
    private void Awake() {
        controls = new PlayerControls();
        controls.Gameplay.Reset.performed += ctx => resetShip();
    }

    void Start(){
        rigidbody = GetComponent<Rigidbody>();
        startPos = rigidbody.position;
        startRot = rigidbody.rotation;
    }
    void resetShip(){
        rigidbody.position = startPos;
        rigidbody.rotation = startRot;
        rigidbody.velocity = Vector3.zero;
    }
    void FixedUpdate(){
        if (controls.Gameplay.Accelerate.ReadValue<float>() > 0){
            accelerate();
        }
        turning();
        pitch();
        
    }

    //apply acceleration
    void accelerate(){
        if (rigidbody.velocity.magnitude < topSpeed){
            Vector3 thrustForce = Vector3.forward * thrust;
            rigidbody.AddRelativeForce(thrustForce, ForceMode.Acceleration);
        }
    }

    //apply turning
    void turning(){
        float rotate = handling * controls.Gameplay.Steering.ReadValue<float>();
        float roll = - bodyRotation * controls.Gameplay.Steering.ReadValue<float>();
        Quaternion rollAngle = transform.rotation * Quaternion.Euler(0f, 0f, roll);
        shipBody.rotation = Quaternion.Lerp(shipBody.rotation, rollAngle, Time.deltaTime * 10f);

        Vector3 rotation = Vector3.up * rotate;

        rigidbody.AddRelativeTorque(rotation, ForceMode.Acceleration);
    
    }

    void pitch(){
        float rotate = pitchRotation * controls.Gameplay.Pitch.ReadValue<float>();
        Vector3 rotation = Vector3.right * rotate;
        rigidbody.AddRelativeTorque(rotation, ForceMode.Acceleration);
    }

    private void OnEnable() {
        controls.Gameplay.Enable();   
    }
    private void OnDisable() {
        controls.Gameplay.Disable();
    }
    
}
