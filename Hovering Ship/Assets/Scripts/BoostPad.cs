using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPad : MonoBehaviour{
    public int boostValue = 10;

    void OnTriggerEnter(Collider other){
        // print("BOOST");
        // print(other.gameObject.GetType());
        if (other.gameObject.tag == "Ship"){
            StartCoroutine(boost(other));
        }
    }

    IEnumerator boost(Collider ship){
        Rigidbody rigidbody = ship.GetComponent<Rigidbody>();
        rigidbody.AddForce(- transform.right * boostValue, ForceMode.VelocityChange);
        yield return new WaitForSeconds(.5f);

    }
    

}
