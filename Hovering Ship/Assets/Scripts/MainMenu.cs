using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void options(){

    }
    public void quit(){
        Application.Quit();
    }
    public void setQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }


}
