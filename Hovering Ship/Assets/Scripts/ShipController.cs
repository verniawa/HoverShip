using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour{
    Rigidbody rigidbody;
    public Transform shipBody;
    public ShipScriptable ship;
    public float thrust, speed;
    public float topSpeed;
    public float handling, bodyRotation, pitchRotation;
    Vector3 startPos;
    Quaternion startRot;
    PlayerControls controls;
    public float airBrakeFactor = 1;
    public GameObject leftAirBrake, rightAirBrake;
    private float speedScale = .001f;
    
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
        updatePosition();
        if (controls.Gameplay.Accelerate.ReadValue<float>() > 0){
            accelerate();
        } else{
            decelerate();
        }
        turning();
        pitch();
        if (controls.Gameplay.AirBrakeLeft.ReadValue<float>() > 0 ){
            AirBrakeLeft();
        }
        if (controls.Gameplay.AirBrakeRight.ReadValue<float>() > 0){
            AirBrakeRight();
        }
        
    }

    //apply acceleration
    void accelerate(){
        if (speed < topSpeed){
            speed += thrust;
        } else {
            speed = topSpeed;
        }
    }

    void decelerate(){
        speed *= .995f;
    }

    void updatePosition(){
        // transform.position += speedScale * speed * transform.forward;
        rigidbody.AddForce(speedScale * speed * transform.forward, ForceMode.VelocityChange);

        float sidewaysSpeed = Vector3.Dot(rigidbody.velocity, transform.right);
        Vector3 sideFriction = -transform.right * (sidewaysSpeed / Time.fixedDeltaTime / 2);
        rigidbody.AddForce(sideFriction, ForceMode.Acceleration);
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

    void AirBrakeLeft(){
        // Vector3 brakeForceLeft = - airBrakeFactor * Vector3.up;
        // //calculate force proportional to velocity
        // float fwdSpeed = transform.InverseTransformDirection(rigidbody.velocity).z;
        // brakeForceLeft = brakeForceLeft * fwdSpeed;
        // rigidbody.AddRelativeTorque(brakeForceLeft, ForceMode.Acceleration);
        // //apply the force
    }

    void AirBrakeRight(){
        // //apply force at wing of ship
        // Vector3 brakeForceRight = -(rigidbody.velocity)* airBrakeFactor;
        // //calculate force proportional to velocity
        // rigidbody.AddForceAtPosition(brakeForceRight, rightAirBrake.transform.position, ForceMode.Acceleration);
        // //apply the force
        
    }

    private void OnEnable() {
        controls.Gameplay.Enable();   
    }
    private void OnDisable() {
        controls.Gameplay.Disable();
    }
    
}
