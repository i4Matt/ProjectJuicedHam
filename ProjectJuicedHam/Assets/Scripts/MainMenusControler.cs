using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenusControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public GameObject PauseMenuUI;
    public static bool menuOpen = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (menuOpen)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        menuOpen = true;


    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        menuOpen = false;
    }

    public void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit(); 
    }
}
