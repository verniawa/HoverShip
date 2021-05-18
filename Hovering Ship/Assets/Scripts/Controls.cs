using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    PlayerControls playerControls;

    ShipController ship;

    void Start(){
        ship = GetComponent<ShipController>();
    }
    
    void Update(){
        
    }
    private void OnEnable() {
        playerControls.Gameplay.Enable();   
    }
    private void OnDisable() {
        playerControls.Gameplay.Disable();
    }
}
