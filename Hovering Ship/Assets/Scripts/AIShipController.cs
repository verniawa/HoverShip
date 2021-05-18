using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShipController : MonoBehaviour {

    public Transform checkpointsParent;
    Transform[] checkpoints;

    Transform waypoint;
    int nextCheckpointIndex;
    public ShipController shipController;

    void Start(){
        nextCheckpointIndex = 0;

    }


    void Update(){
        
        
    }

    void Reset(){
        checkpointsParent = GameObject.FindGameObjectWithTag("Checkpoint").transform;
        checkpoints = new Transform[checkpointsParent.childCount];
        for (int i = 0; i < checkpoints.Length; i++){
            checkpoints[i] = checkpointsParent.GetChild(i);
        }
        
    }



}
