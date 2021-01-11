using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipSelect : MonoBehaviour{
    // PlayerControls controls;
    private GameObject[] shipList;
    public Ship playerChoice;
    private int index = 0;
    public float rotation;
    public Texture[] textures;
    public int currentTexture;
    public Material material;
    
    void Start(){
        // controls = new PlayerControls();
        shipList = new GameObject[transform.childCount];
        for(int i = 0; i < transform.childCount; i++){
            shipList[i] = transform.GetChild(i).gameObject;
            shipList[i].SetActive(false);
        }
        if (shipList[0]){
            shipList[0].SetActive(true);
        }

    }

    void Update(){
        Vector3 rotate = new Vector3(0,rotation, 0);
        transform.Rotate(rotate * Time.deltaTime);

    }

    public void previous(){
        shipList[index].SetActive(false);
        index--;
        if (index < 0){
            index = shipList.Length - 1;
        }
        shipList[index].SetActive(true);

    }
    public void next(){
        shipList[index].SetActive(false);
        index++;
        index = index % shipList.Length;
        shipList[index].SetActive(true);
    }

    public void nextTexture(){
        currentTexture++;
        currentTexture %= textures.Length;
        material.mainTexture = textures[currentTexture];
    }

    public void prevTexture(){
        currentTexture--;
        if (currentTexture < 0){
            currentTexture = textures.Length - 1;
        }
        material.mainTexture = textures[currentTexture];
    }


    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        playerChoice.mesh = shipList[index].GetComponent<MeshFilter>().mesh;

        PlayerPrefs.SetInt("SelectedShip", index);
    }
    
}
