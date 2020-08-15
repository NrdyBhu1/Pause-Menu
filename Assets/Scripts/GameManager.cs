using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    public Canvas pauseCanvas = null;
    #endregion
    private void Start() {
        if(pauseCanvas != null){
            pauseCanvas.gameObject.SetActive(false);
        }
    }
    public void loadGame(){
        SceneManager.LoadScene("Game");
    }

    public void Quit(){
        Application.Quit();
    }

    public void loadMenu(){
        SceneManager.LoadScene("SampleScene");
    }

    void Pause(){
        if(pauseCanvas != null){
            pauseCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Resume(){
        if(pauseCanvas != null){
            pauseCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void Update() {
        if(Input.GetKey("escape")){
            Pause();
        }
    }
}
