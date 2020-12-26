using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneController : Singleton<SceneController>
{
    [SerializeField] private GameObject mainButtons;
    [SerializeField] private GameObject howToPlayPanel;

    private void Start()
    {
        SoundManager.Instance.PlaySound(SoundManager.Sound.StartSound);
    }
    public enum Scene
    {
        Start,
        Game
    };
    public void MoveToScene(int scene)
    {
        switch (scene)
        {
            case (int)Scene.Game:
                SoundManager.Instance.PlaySound(SoundManager.Sound.GameSound);
                SceneManager.LoadScene(1);
                break;
            case (int)Scene.Start:
                SoundManager.Instance.PlaySound(SoundManager.Sound.StartSound);
                SceneManager.LoadScene(0);
                break;
        }
        SoundManager.Instance.PlaySound(SoundManager.Sound.buttonSound);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void EnableHowToCanvas()
    {
        mainButtons.SetActive(false);
        howToPlayPanel.SetActive(true);
        SoundManager.Instance.PlaySound(SoundManager.Sound.buttonSound);
    }
    public void DisableHowToCanvas()
    {
        howToPlayPanel.SetActive(false);
        mainButtons.SetActive(true);
        SoundManager.Instance.PlaySound(SoundManager.Sound.buttonSound);
    }
}
