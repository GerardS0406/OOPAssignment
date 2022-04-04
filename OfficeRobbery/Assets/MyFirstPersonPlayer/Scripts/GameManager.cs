/*
* Gerard Lamoureux
* Assignment 6
* Handles Score and Score UI
* and loading/unloading scenes
*/

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int score = 0;

    public GameObject pauseMenu;
    public GameObject retryMenu;

    //variable to keep track of current level
    private string CurrentLevelName = string.Empty;

    //methods to load/unload scenes

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !retryMenu.activeSelf)
            Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        retryMenu.SetActive(false);
    }

    public void OutofTime()
    {
        Time.timeScale = 0f;
        retryMenu.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        UnloadCurrentLevel();
        LoadLevel(CurrentLevelName);
        retryMenu.SetActive(false);
    }

    public void PlayerWin()
    {

    }

}