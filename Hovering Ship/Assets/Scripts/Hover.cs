using UnityEngine;

public class Hover : MonoBehaviour{
    public GameObject trigger;
    public float lift, fallSpeed;
    public float hoverHeight;
    float distanceToGround;
    Rigidbody rigidbody;
    float x, y, z;
    Vector3[] hoverPointsLocations;
    public int hoverExp;
    public GameObject[] hoverPoints;
    
    

    void Start(){
        rigidbody = GetComponent<Rigidbody>();

        hoverPointsLocations = new Vector3[4];
        
        for (int i = 0; i < hoverPoints.Length; i++){
            hoverPointsLocations[i] = hoverPoints[i].transform.position;
        }
    }

    void FixedUpdate(){
        calculateLift();
        if (isAirborn(2)){
            stabilize();
        }
        fastFall();
    }


    //method to calculate lift forces on ship
    void calculateLift(){
        for (int i = 0; i < hoverPointsLocations.Length; i++){
            Ray ray = new Ray(hoverPoints[i].transform.position, -transform.up);
            
            RaycastHit hitInfo;
            //checks if the hover point is close enoough to the ground
            if (Physics.Raycast(ray, out hitInfo, hoverHeight)){
                float percentForce;
                //experimenting with different exponential hover force calculations
                if(hoverExp == 1){
                    percentForce = hoverHeight - hitInfo.distance;
                } else{
                    percentForce = Mathf.Pow(hoverHeight - hitInfo.distance, hoverExp);
                }

                //creates a force based on the distance to the ground from that point
                Vector3 force = transform.up * percentForce * lift ;
                // Debug.DrawRay(ray.origin, ray.direction, Color.green,1);//debug
                
                rigidbody.AddForceAtPosition(force, hoverPoints[i].transform.position);
                
            }
        }
    }

    //when the ship is airborn, slowly change rotation so that it's facing upward
    void stabilize(){
        Quaternion rollAngle = Quaternion.Euler(0f, rigidbody.rotation.eulerAngles.y, 0f);
        rigidbody.rotation = Quaternion.Lerp(rigidbody.rotation, rollAngle, Time.deltaTime);
    }

    void fastFall(){
        //makes ship fall faster when in the air
        if (isAirborn(1.1f)){
            rigidbody.AddForce(Vector3.down * fallSpeed, ForceMode.Acceleration);

        }
    }

    bool isAirborn(float factor){
        Ray ray = new Ray(transform.position, -transform.up);
        return !Physics.Raycast(ray, hoverHeight * factor);
    }



}
