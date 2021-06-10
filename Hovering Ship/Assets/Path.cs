using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour {


    Transform[] transforms;
    void Awake(){
    }
    void  OnDrawGizmosSelected(){
        transforms = GetComponentsInChildren<Transform>();
        Gizmos.color = Color.cyan;
        for (int i = 0; i < transforms.Length; i++){
            Vector3 currentNode = transforms[i].position;
            Vector3 previousNode = Vector3.zero;
            if (i > 0){
                previousNode = transforms[i - 1].position;
            } else if (i == 0 && transforms.Length > 1){
                previousNode = transforms[transforms.Length - 1].position;
            }

            Gizmos.DrawLine(previousNode, currentNode);
            Gizmos.DrawWireSphere(currentNode, .3f);
        }
    }
}
