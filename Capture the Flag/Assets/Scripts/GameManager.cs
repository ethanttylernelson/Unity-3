using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Flag Stats")]

    public bool hasFlag;

    public bool flagPlaced;

    public int scoreToWin;

    public int curScore;

    public bool gamePaused;

    public static GameManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        hasFlag = false;
        flagPlaced = false;

        Time.timeScale = 1.0f;
    }

    void Update() 
    {
        if(flagPlaced)
        {
            WinGame();
        }

        if(Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }
    public void TogglePauseGame()
{
    gamePaused = !gamePaused;
    Time.timeScale = gamePaused == true ? 0.0f : 1.0f;

    GameUI.instance.TogglePauseMenu(gamePaused);
    Cursor.lockState = gamePaused == true? CursorLockMode.None : CursorLockMode.Locked;
}

public void AddScore(int score)
{
    curScore += score;

    GameUI.instance.UpdateScoreText(curScore);

    if(curScore >= scoreToWin)
    WinGame();
}

void WinGame()
{
    Debug.Log("You've won the game!");

    //GameUI.instance.SetEndGameScreen(true,curScore);

    Time.timeScale = 0;
}

void LoseGame()
{
    Time.timeScale = 0;
    gamePaused = true;
    Debug.Log("You've lost the game! Try again.");
}
public void PlaceFlag()
{
    flagPlaced = true;
}

}


