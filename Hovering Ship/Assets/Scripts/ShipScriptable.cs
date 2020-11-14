using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ship", menuName = "Ship")]
public class ShipScriptable : ScriptableObject {
    public string name;
    public int index;
    public GameObject model;
}
