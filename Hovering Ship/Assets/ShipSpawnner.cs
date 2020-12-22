using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawnner : MonoBehaviour{
    public MeshFilter meshFilter;
    public Mesh mesh;
    void Reset(){
        meshFilter = GetComponent<MeshFilter>();
        
    }
    void Start(){
        meshFilter.mesh = mesh;
    }
}