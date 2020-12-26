using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Hydra;
using UnityEditor;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [Header("Lose Screen Attributes")] 
    [SerializeField] private GameObject loseScreenPanel;
    [SerializeField] private Image loseScreenBG;
    [SerializeField] private GameObject loseScreenText;
    [SerializeField] private float animationDuration = 1.2f;
    public float mapLength = 100f;

    private void Awake()
    {
        Instance = this;
    }


    #region menus
    [MenuItem("Manager/Lose")]
    public static void Lose_Menu()
    {
        Instance.Lose();

    }

    [MenuItem("Manager/Win")]
    public static void Win_Menu()
    {
        Instance.Win();
    }

    [MenuItem("Manager/Restart")]
    public static void Restart_Menu()
    {
        Instance.RestartGame();
    }

    #endregion

    public void Lose()
    {
        Time.timeScale = 0f;
        StartCoroutine(AnimateLoseScreen());
    }

    private IEnumerator AnimateLoseScreen()
    {
        
        loseScreenPanel.SetActive(true);
        loseScreenText.SetActive(false);
        var originalColor = loseScreenBG.color;
        float alpha = originalColor.a;
        originalColor.a = 0;
        loseScreenBG.color = originalColor;
        loseScreenBG.DOFade(alpha, animationDuration).SetUpdate(true);
        yield return new WaitForSecondsRealtime(animationDuration / 3);
        loseScreenText.SetActive(true);
        loseScreenText.transform.DOMoveY(0f, animationDuration*2).From().SetEase(Ease.OutBounce).SetUpdate(true);
    }
    
    
    
    public void Win()
    {
        
    }

    public void RestartGame()
    {
        ResetTimeScale();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        HydraHead.ResetHeads();
    }

    public void ResetTimeScale()
    {
        Time.timeScale = 1;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(mapLength, 1, 0));
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, new Vector3(mapLength, .5f, 0));
    }
}
