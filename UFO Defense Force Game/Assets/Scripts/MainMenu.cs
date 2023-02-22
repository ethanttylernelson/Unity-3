using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private int sceneToLoad;


    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("New Scene Loaded!");
    }
   public void QuitGame()
   {
    Application.Quit();
    Debug.Log("You have quit the game!");
   }
  
}
