using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ship", menuName = "Ship")]
public class Ship : ScriptableObject {
    public string shipName;
    public enum controlType {player, AI};

    public Mesh mesh;
}
