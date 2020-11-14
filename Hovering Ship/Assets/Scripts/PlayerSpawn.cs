using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour{

    public GameObject[] ships;
    GameObject playerShip;

    void Awake(){
        int index = PlayerPrefs.GetInt("SelectedShip", 0); 
        if (index < ships.Length && index >= 0){   
            playerShip = Instantiate(ships[index], transform);
        } else{
            playerShip = Instantiate(ships[0]);
        }
    }

}