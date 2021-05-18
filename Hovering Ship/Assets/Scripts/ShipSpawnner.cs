﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawnner : MonoBehaviour{
    private MeshFilter meshFilter;

    public Ship playerShip;

    void Reset(){
    }

    void Start(){
        meshFilter = GetComponent<MeshFilter>();
        if(playerShip.mesh){
            meshFilter.mesh = playerShip.mesh;
        }
    }
    

}