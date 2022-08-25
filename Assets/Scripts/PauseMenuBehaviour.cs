using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuBehaviour : MonoBehaviour
{
    private bool paused;
    public GameObject pauseMenu;
    public AudioSource bubblePop;

    private void Start() 
    {
        pauseMenu.SetActive(false);
        paused = false;
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseState();
        }
    }

    public void PauseState()
    {
        if(paused)
        {
            Time.timeScale = 1;
            paused = false;
            pauseMenu.SetActive(false);
            bubblePop.Play();
        }
        else
        {
            Time.timeScale = 0;
            paused = true;
            pauseMenu.SetActive(true);
            bubblePop.Play();
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
        bubblePop.Play();
    }
}
