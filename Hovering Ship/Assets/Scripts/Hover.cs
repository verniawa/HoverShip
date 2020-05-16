﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour{
    public GameObject trigger;
    public float lift, airGravity;
    public float hoverHeight;
    float distanceToGround;
    public PID pID;
    Rigidbody rigidbody;
    float x, y, z;
    Vector3[] hoverPoints;
    public int hoverExp;
    
    

    void Start(){
        rigidbody = GetComponent<Rigidbody>();

        //placeholder code just to get it working temporarily
        //supposed to be references to the location of the corners of the collider
        float maxX = transform.localScale.x / 5;
        float maxY = transform.localScale.y / 2;
        float maxZ = transform.localScale.z / 10;

        hoverPoints = new Vector3[4];
        hoverPoints[0] = new Vector3(maxX , maxY, maxZ);
        hoverPoints[1] = new Vector3(maxX, maxY, -maxZ);
        hoverPoints[2] = new Vector3(-maxX, maxY, maxZ);
        hoverPoints[3] = new Vector3(-maxX,  maxY, -maxZ);
    }

    void FixedUpdate(){
        calculateLift();
        if (isAirborn()){
            stabilize();
        }
    }


    //method to calculate lift forces on ship
    void calculateLift(){
        for (int i = 0; i < hoverPoints.Length; i++){
            Ray ray = new Ray(transform.TransformPoint(hoverPoints[i]), -transform.up);
            
            RaycastHit hitInfo;
            //checks if the hover point is close enoough to the ground
            if (Physics.Raycast(ray, out hitInfo, hoverHeight)){
                float percentForce;
                //experimenting with different exponential hover force calculations
                if(hoverExp == 1){
                    percentForce = hoverHeight - hitInfo.distance;
                } else{
                    percentForce = Mathf.Pow(hoverHeight - hitInfo.distance, hoverExp);
                }

                //creates a force based on the distance to the ground from that point
                Vector3 force = transform.up * percentForce * lift ;
                Debug.DrawRay(ray.origin, ray.direction, Color.green,1);//debug
                
                rigidbody.AddForceAtPosition(force, ray.origin);
                
            } else { //replace this eventually, not the best solution
                //makes ship fall faster when in the air
                rigidbody.AddForce(Vector3.down * airGravity, ForceMode.Acceleration);
            }
        }
    }

    //when the ship is airborn, slowly change rotation so that it's facing upward
    void stabilize(){
        Quaternion rollAngle = Quaternion.Euler(0f, rigidbody.rotation.eulerAngles.y, 0f);
        rigidbody.rotation = Quaternion.Lerp(rigidbody.rotation, rollAngle, Time.deltaTime);
    }


    bool isAirborn(){
        Ray ray = new Ray(transform.position, -transform.up);
        return !Physics.Raycast(ray, hoverHeight * 2);
    }

}
