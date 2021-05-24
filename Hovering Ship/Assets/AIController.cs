using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AIController : MonoBehaviour {

    ShipController shipController;
    bool accel, leftBrake, rightBrake;
    float steer, pitch;

    [SerializeField] LapManager lapManager;
    [SerializeField] GameObject checkpointsParent;
    private Transform[] wayPoints;
    private Vector3 target;
    private int index;
    float angleToTarget;

    void Start(){
        shipController = GetComponent<ShipController>();
        wayPoints = checkpointsParent.GetComponentsInChildren<Transform>();
        index = 0;

        target = wayPoints[index].transform.position;

        lapManager.OnCheckpoint += checkpointEvent;
    }

    private void checkpointEvent(object sender, EventArgs e){
        nextWaypoint();
    }
    void Update(){
        
        float distanceToTarget = Vector3.Distance(transform.position, target);
        if (distanceToTarget < 10){
            nextWaypoint();
        }

        accel = true;
        
        Vector3 dirToTarget = (target - transform.position).normalized;
        angleToTarget = Vector3.SignedAngle(transform.forward, dirToTarget, Vector3.up);


        Debug.DrawLine(transform.position, target, Color.magenta);

        if (angleToTarget > 0.5){
            steer = 1f;
        } else if (angleToTarget < -0.5){
            steer = -1f;
        } else steer = 0;
        
        if (Math.Abs(transform.rotation.x) > 160){
            shipController.resetShip();
        }
        


        shipController.setInputs(accel, steer, pitch, leftBrake, rightBrake);
    }

    void nextWaypoint(){
        index ++;
        index = lapManager.lastCheckpointPassed + 2;
        if (index >= wayPoints.Length){
            index = 0;
        }
        target = wayPoints[index].position;
    }
}
