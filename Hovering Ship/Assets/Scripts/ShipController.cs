using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShipController : MonoBehaviour {
    

    #region Input Vars
    private bool accel, leftBrake, rightBrake;
    private float steer, pitch;
    #endregion

    // this is how we will interface with the class
    public void setInputs(bool accel, float steer, float pitch, bool leftBrake, bool rightBrake){
        this.accel = accel;
        this.steer = steer;
        this.pitch = pitch;
        this.leftBrake = leftBrake;
        this.rightBrake = rightBrake;
    }

    private float speed, speedScale = .001f;
    Vector3 startPos;
    Quaternion startRot;

    [Header("Ship Attributes")]
    public float topSpeed;
    public float thrust, handling, pitchAmount;
    [SerializeField] float bodyRotation;



    #region Components
    [SerializeField] Transform shipBody; //manual reference to ship body for now
    Rigidbody rb;
    LapManager lapManager;
    #endregion
    void Awake(){
        rb = GetComponent<Rigidbody>();
        lapManager = GetComponent<LapManager>();
        lapManager.OnCheckpoint += updateCheckpoint;
        // shipBody = transform.Find("AGS");
    }

    private void Start() {
        startPos = rb.position;
        startRot = rb.rotation;
    }

    void FixedUpdate(){
        accelerate();
        steering();
        pitching();
        updatePosition();
    }


    void accelerate(){
        if (accel){    
            if (speed < topSpeed){
                speed += thrust;
            } else {
                speed = topSpeed;
            }
        } else{
            speed *= .995f;
        }
    }

    void steering(){
        float rotate = handling * steer;
        float roll = - bodyRotation * steer;
        Quaternion rollAngle = transform.rotation * Quaternion.Euler(0f, 0f, roll);
        shipBody.rotation = Quaternion.Lerp(shipBody.rotation, rollAngle, Time.deltaTime * 10f);
        rb.AddRelativeTorque(Vector3.up * rotate, ForceMode.Acceleration);
    }
    void pitching(){
        Vector3 rotation = Vector3.right * (pitch * pitchAmount);
        rb.AddRelativeTorque(rotation, ForceMode.Acceleration);
    }

    void updatePosition(){
        rb.AddForce(speedScale * speed * transform.forward, ForceMode.VelocityChange);
        float sidewaysSpeed = Vector3.Dot(rb.velocity, transform.right);
        Vector3 sideFriction = -transform.right * (sidewaysSpeed / Time.fixedDeltaTime / 2);
        rb.AddForce(sideFriction, ForceMode.Acceleration);
    }

    public void resetShip(){
        rb.position = startPos;
        rb.rotation = startRot;
        rb.velocity = Vector3.zero;
    }

    void updateCheckpoint(object sender, EventArgs e){
        startPos = rb.position;
    }

}
