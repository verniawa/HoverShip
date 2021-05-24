using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject UIPanel;
    public TextMeshProUGUI UIcurrentLap;
    public TextMeshProUGUI UICurrentLapTime;
    public TextMeshProUGUI UIlastLapTime;
    public TextMeshProUGUI UIbestTime;

    public LapManager updateUIForPlayer;
    public Rigidbody rb;
    public TextMeshProUGUI UISpeed;

    private int currentLap = -1;
    private float currentLapTime, lastLapTime, bestTime;
    private int speed;

    void Update(){
        if(updateUIForPlayer.currentLap != currentLap){
            currentLap = updateUIForPlayer.currentLap;
            UIcurrentLap.text = $"Lap: {currentLap}";
        }
        if (updateUIForPlayer.lastLapTime != lastLapTime){
            lastLapTime = updateUIForPlayer.lastLapTime;
            UIlastLapTime.text = $"Previous: {(int)lastLapTime / 60}:{lastLapTime % 60:00.000}";
        }
        if (updateUIForPlayer.currentLapTime != currentLapTime){
            currentLapTime = updateUIForPlayer.currentLapTime;
            UICurrentLapTime.text = $"Time: {(int)currentLapTime / 60}:{currentLapTime % 60:00.000}";
        }
        if (updateUIForPlayer.bestLapTime != bestTime && updateUIForPlayer.bestLapTime < Mathf.Infinity){
            bestTime = updateUIForPlayer.bestLapTime;
            UIbestTime.text = $"Best: {(int)bestTime / 60}:{bestTime % 60:00.000}";
        }
        if ((int) rb.velocity.magnitude != speed){
            speed = (int) rb.velocity.magnitude;
            UISpeed.text = $"Speed: {speed}";
        }
    }
}
