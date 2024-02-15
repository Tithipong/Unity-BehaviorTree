using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlBT : GameController
{
    [SerializeField] private Button enableButton;
    [SerializeField] private Button disableButton;
    public void Start()
    {
        disableButton.gameObject.SetActive(false);
    }
        public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ShowMap()
    {
        Time.timeScale = 0f;
        map.enabled = true;
        enableButton.gameObject.SetActive(false);
        disableButton.gameObject.SetActive(true);
    }
    public void DisableMap()
    {
        Time.timeScale = 1f;
        map.enabled = false;
        enableButton.gameObject.SetActive(true);
        disableButton.gameObject.SetActive(false);
    }
}
