using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AIController : MonoBehaviour {

    ShipController shipController;
    bool accel, leftBrake, rightBrake;
    float steer, pitch;

    float maxSteer;

    [SerializeField] LapManager lapManager;
    [SerializeField] GameObject waypointsParent;
    private List<Transform> wayPoints;
    private Vector3 target;
    private int index;
    float angleToTarget;

    void Start(){
        shipController = GetComponent<ShipController>();
        wayPoints = new List<Transform>(waypointsParent.GetComponentsInChildren<Transform>());
        index = 0;

        target = wayPoints[index].transform.position;

        lapManager.OnCheckpoint += checkpointEvent;

        maxSteer = shipController.handling;
    }

    private void checkpointEvent(object sender, EventArgs e){
        // nextWaypoint();
    }
    void Update(){
        checkForReset();
        // avoidWalls();
        Vector3 modifiedTarget = target;
        modifiedTarget.y = transform.position.y;


        float distanceToTarget = Vector3.Distance(transform.position, modifiedTarget);
        if (distanceToTarget < 15){
            nextWaypoint();
        }

        accel = true;

        Vector3 dirToTarget = (modifiedTarget - transform.position).normalized;

        angleToTarget = Vector3.SignedAngle(transform.forward, dirToTarget, Vector3.up);


        // Debug.DrawLine(transform.position, target, Color.magenta);

        if (angleToTarget > 20){
            steer = 1;
            accel = false;
        } else if (angleToTarget < -20){
            steer = -1;
            accel = false;
        } else {
            steer = angleToTarget / distanceToTarget;
        }

        // if (angleToTarget > 0.5){
        //     steer = 1f;
        // } else if (angleToTarget < -0.5){
        //     steer = -1f;
        // } else steer = 0;
        
        // if (Math.Abs(transform.rotation.x) > 160){
        //     shipController.resetShip();
        // }
        shipController.setInputs(accel, steer, pitch, leftBrake, rightBrake);
    }

    void checkForReset(){
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, .1f);
        if (hit.collider != null){
            shipController.resetShip();
        }
    }

    void avoidWalls(){


        Ray[] sensors = new Ray[5];
        sensors[0] = new Ray(transform.position, -transform.right);
        sensors[3] = new Ray(transform.position, (transform.forward - transform.right));
        sensors[2] = new Ray(transform.position, transform.forward);
        sensors[3] = new Ray(transform.position, (transform.forward + transform.right));
        sensors[4] = new Ray(transform.position, transform.right);

        RaycastHit[] hits = new RaycastHit[4];

        for(int i = 0; i < sensors.Length; i++){
            Physics.Raycast(sensors[i], out hits[i], 30);
        }


        Ray left = new Ray(transform.position, -transform.right);
        Ray right = new Ray(transform.position, transform.right);
        RaycastHit leftHit, rightHit;
        Physics.Raycast(left, out leftHit, 30);
        Physics.Raycast(right, out rightHit, 30);
        Debug.Log("LEFT: " + leftHit.distance + " RIGHT: " + rightHit.distance);
        if (leftHit.distance == 0){
            steer = 1f;
        }else if (rightHit.distance == 0){
            steer = -1f;
        }
        else if (leftHit.distance < rightHit.distance){
            steer = -1f;
        } else if (rightHit.distance < leftHit.distance){
            steer = 1f;
        }
        
    }
    

    void nextWaypoint(){
        index ++;
        
        if (index >= wayPoints.Count){
            index = 0;
        }
        target = wayPoints[index].position;
    }
}
