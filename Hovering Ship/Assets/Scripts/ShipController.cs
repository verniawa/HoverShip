﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float lift, airGravity;
    public float hoverHeight;
    float distanceToGround;
    public PID pID;
    Rigidbody rigidbody;
    public Transform shipBody;
    public float thrust;
    public float topSpeed;
    public float handling, bodyRotation, pitchRotation;
    float x, y, z;
    Vector3 startPos;
    Quaternion startRot;
    Vector3[] hoverPoints;
    public bool hoverType;
    public int hoverExp;


    void Start(){
        rigidbody = GetComponent<Rigidbody>();
        float maxX = transform.localScale.x / 5;
        float maxY = transform.localScale.y / 2;
        float maxZ = transform.localScale.z / 10;


        
        hoverPoints = new Vector3[4];
        hoverPoints[0] = new Vector3(maxX , maxY, maxZ);
        hoverPoints[1] = new Vector3(maxX, maxY, -maxZ);
        hoverPoints[2] = new Vector3(-maxX, maxY, maxZ);
        hoverPoints[3] = new Vector3(-maxX,  maxY, -maxZ);

        

        startPos = rigidbody.position;
        startRot = rigidbody.rotation;

    }

    


    void FixedUpdate(){

        calculateLift();
        // Vector3 v = rigidbody.velocity;
        // v.y *= .99f;
        // rigidbody.velocity = v;
        if (Input.GetKey(KeyCode.Space)){
            accelerate();
        }
        turning();
        pitch();
        if (isAirborn()){
            rightShip();
        }
        if (Input.GetKeyDown(KeyCode.R)){//reset button reset ship back to starting position
            rigidbody.position = startPos;
            rigidbody.rotation = startRot;
            rigidbody.velocity = Vector3.zero;
        }
    }


    //method to calculate lift forces on ship
    void calculateLift(){
        for (int i = 0; i < 4; i++){
            Ray ray = new Ray(transform.TransformPoint(hoverPoints[i]), -transform.up);
            
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, hoverHeight)){
                float percentForce;
                if (hoverType){
                    percentForce = pID.Update(hoverHeight, hitInfo.distance, Time.deltaTime);
                }
                else{
                    percentForce = Mathf.Pow(hoverHeight - hitInfo.distance, hoverExp);
                }
                Vector3 force = transform.up * percentForce * lift ;/// hoverPoints.Length;
                Debug.DrawRay(ray.origin, ray.direction, Color.green,1);//debug
                
                rigidbody.AddForceAtPosition(force, ray.origin);
                
            } else { //replace this eventually, not the best solution
                //makes ship fall faster when in the air
                rigidbody.AddForce(Vector3.down * airGravity, ForceMode.Acceleration);
            }
        }
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
        float rotate = handling * Input.GetAxisRaw("Horizontal");
        float roll = - bodyRotation * Input.GetAxisRaw("Horizontal");
        Quaternion rollAngle = transform.rotation * Quaternion.Euler(0f, 0f, roll);
        shipBody.rotation = Quaternion.Lerp(shipBody.rotation, rollAngle, Time.deltaTime * 10f);

        Vector3 rotation = Vector3.up * rotate;

        rigidbody.AddRelativeTorque(rotation, ForceMode.Acceleration);
    
    }

    void rightShip(){
        Quaternion rollAngle = Quaternion.Euler(0f, rigidbody.rotation.eulerAngles.y, 0f);
        rigidbody.rotation = Quaternion.Lerp(rigidbody.rotation, rollAngle, Time.deltaTime);
    }

    bool isAirborn(){
        Ray ray = new Ray(transform.position, -transform.up);
        return !Physics.Raycast(ray, hoverHeight * 2);
    }

    void pitch(){
        float rotate = pitchRotation * Input.GetAxisRaw("Vertical");
        Vector3 rotation = Vector3.right * rotate;
        rigidbody.AddRelativeTorque(rotation, ForceMode.Acceleration);
        
    
    }
}