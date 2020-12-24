using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneController : Singleton<SceneController>
{
    private GameObject helpButtons1;
    private GameObject helpButtons2;

    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject howToPlayPanel;

    private AudioSource buttonClickSound;
    private void Start()
    {
        buttonClickSound = GetComponent<AudioSource>();
    }
    
    public enum Player
    {
        Player1,
        Player2
    };
    public enum Role
    {
        Fire,
        Movement
    };
    public void MoveToScene(string scene)
    {
        SceneManager.LoadScene(scene);
        PlayClickSound();
    }
    public void PlayClickSound()
    {
        buttonClickSound.Play();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void SetHelpButtons(GameObject first,GameObject second)
    {
        helpButtons1 = first;
        helpButtons2 = second;
    }
    public void SetActiveHelpButtons(Player player,Role role,bool setActive)
    {
        if (player == Player.Player1)
        {
            if (role == Role.Fire)
            {
                helpButtons1.transform.GetChild(0).gameObject.SetActive(setActive);
            }
            else
            {
                helpButtons1.transform.GetChild(1).gameObject.SetActive(setActive);
            }
        }
        else
        {
            if (role == Role.Fire)
            {
                helpButtons2.transform.GetChild(0).gameObject.SetActive(setActive);
            }
            else
            {
                helpButtons2.transform.GetChild(1).gameObject.SetActive(setActive);
            }
        }

    }
    public void EnableHowToCanvas()
    {
        mainButtons.SetActive(false);
        howToPlayPanel.SetActive(true);
        PlayClickSound();
    }
    public void DisableHowToCanvas()
    {
        howToPlayPanel.SetActive(false);
        mainButtons.SetActive(true);
        PlayClickSound();
    }
}
