using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class LapManager : MonoBehaviour
{
    private Transform checkpointsParent;
    public int lastCheckpointPassed;
    private float timeStamp;
    public float currentLapTime {get; private set; } = 0;

    public float lastLapTime  {get; private set; } = 0;
    private int checkpointsCount;
    private int checkpointLayer;
    public int currentLap {get; private set; } = 0;
    public float bestLapTime {get; private set; } = Mathf.Infinity / 2;

    public event EventHandler OnCheckpoint;

    //This code is based off a tutorial series by Imphenzia
    //"Low Poly Racing" series https://www.youtube.com/watch?v=h-sEtELln9k 
    

    private void Awake() {
        checkpointsParent = GameObject.Find("Checkpoints").transform;
        checkpointsCount = checkpointsParent.childCount;
        checkpointLayer = LayerMask.NameToLayer("Checkpoint");
        lastCheckpointPassed = 0;
    }

    void startLap(){
        // Debug.Log("start lap");
        currentLap++;
        lastCheckpointPassed = 0;
        timeStamp = Time.time;
    }

    void endLap(){
        lastLapTime = currentLapTime;
        bestLapTime = Mathf.Min(bestLapTime, currentLapTime);   
        currentLapTime = 0;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer == checkpointLayer){
            OnCheckpoint?.Invoke(this, EventArgs.Empty);
            if(other.gameObject.name == "0"){
                if(lastCheckpointPassed == checkpointsCount - 1){
                    endLap();
                }
                if (currentLap == 0 || lastCheckpointPassed == checkpointsCount - 1){
                    startLap();
                }
            }
            if(other.gameObject.name ==(lastCheckpointPassed + 1).ToString()){
                lastCheckpointPassed++;
            }
        }
    }

    void Update(){
        if (currentLap > 0){
            currentLapTime = Time.time - timeStamp;
        }
    }
}
