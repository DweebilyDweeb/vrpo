using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas LevelSelectCanvas;
    public Canvas PauseCanvas;
    public Canvas PlayCanvas;
    private float savedTimeScale;
    bool MainOrGame;

    void Awake()
    {
        if (OptionsCanvas == null && LevelSelectCanvas == null && PauseCanvas == null)
            return;
        if (OptionsCanvas != null)
        OptionsCanvas.enabled = false;

        if (LevelSelectCanvas != null)
        LevelSelectCanvas.enabled = false;

        if (PauseCanvas != null)
        PauseCanvas.enabled = false;

        if (PlayCanvas != null)
            PlayCanvas.enabled = false;

    }
    void Start()
    {

        AudioListener.pause = false;
        Time.timeScale = 1;
        MainOrGame = true;
    }


    public void MainOn()
    {
        Time.timeScale = 1;
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = true;
        LevelSelectCanvas.enabled = false;
        PauseCanvas.enabled = false;
        PlayCanvas.enabled = false;
    }
    public void OptionsOn()
    {
        if(MainCanvas.enabled == true)
        {
            MainOrGame = true;
        }
        if (PauseCanvas.enabled == true)
        {
            MainOrGame = false;
        }
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
        LevelSelectCanvas.enabled = false;
        PauseCanvas.enabled = false;
        PlayCanvas.enabled = false;
    }

    public void LevelSelectOn()
    {
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        LevelSelectCanvas.enabled = true;
        PauseCanvas.enabled = false;
        PlayCanvas.enabled = false;
    }

    public void PauseOn()
    {
        PauseTime();
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        LevelSelectCanvas.enabled = false;
        PauseCanvas.enabled = true;
        PlayCanvas.enabled = false;
    }
    public void PlayOn()
    {
        Time.timeScale = 1;
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
        LevelSelectCanvas.enabled = false;
        PauseCanvas.enabled = false;
        PlayCanvas.enabled = true;
    }
    public void ReturnOn()
    {
        if (MainOrGame == true)
        {
            MainOn();
            Time.timeScale = 1;
        }
        if (MainOrGame == false)
        {
            PauseOn();
        }
    }

    public void GoToShowcase()
    {
        SceneManager.LoadScene("Showcase");
        PlayOn();
    }   

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level_1");
        PlayOn();
    }
    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level_2");
        PlayOn();
    }
    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level_3");
        PlayOn();
    }
    public void GoToLevel4()
    {
        SceneManager.LoadScene("Level_4");
        PlayOn();
    }

    public void PauseTime()
    {
        savedTimeScale = Time.timeScale;
        Time.timeScale = 0;
        //AudioListener.pause = true;
    }

    public void UnpauseTime()
    {
        Time.timeScale = savedTimeScale;
        AudioListener.pause = false;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        MainOn();
    }

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("MainMenu");
        LevelSelectOn();
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
