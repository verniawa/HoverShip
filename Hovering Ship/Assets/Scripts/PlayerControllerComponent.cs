using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerComponent : MonoBehaviour {

    PlayerControls controls;

    bool accel, leftBrake, rightBrake;
    float steer, pitch;
    ShipController shipController;
    void Awake(){
        shipController = GetComponent<ShipController>();
        controls = new PlayerControls();
    }


    void FixedUpdate(){
        accel = controls.Gameplay.Accelerate.ReadValue<float>() > 0;
        steer = controls.Gameplay.Steering.ReadValue<float>();
        pitch = controls.Gameplay.Pitch.ReadValue<float>();
        leftBrake = controls.Gameplay.AirBrakeLeft.ReadValue<float>() > 0;
        rightBrake = controls.Gameplay.AirBrakeRight.ReadValue<float>() > 0;

        shipController.setInputs(accel, steer, pitch, leftBrake, rightBrake);

        if (controls.Gameplay.Reset.ReadValue<float>() > 0){
            shipController.resetShip();
        }
    }

    private void OnEnable() {
        controls.Gameplay.Enable();   
    }
    private void OnDisable() {
        controls.Gameplay.Disable();
    }
    
}
