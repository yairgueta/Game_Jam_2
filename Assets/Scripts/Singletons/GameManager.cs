using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Enemies;
using Hydra;
using TMPro;
using UnityEditor;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float mapLength = 100f;
    
    [Header("Lose Screen Attributes")] 
    [SerializeField] private GameObject loseScreenPanel;
    [SerializeField] private Image loseScreenBG;
    [SerializeField] private GameObject loseScreenText;
    [SerializeField] private float loseAnimationDuration = 1.2f;

    [Header("Win Screen Attributes")] 
    [SerializeField] private GameObject winScreenPanel;
    [SerializeField] private Image winScreenBG;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float winAnimationDuration;

    private int score;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        EnemiesManager.Instance.onEnemyDeath.AddListener((e) => score += e.Score);
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
        loseScreenBG.DOFade(alpha, loseAnimationDuration).SetUpdate(true);
        yield return new WaitForSecondsRealtime(loseAnimationDuration / 3);
        loseScreenText.SetActive(true);
        loseScreenText.transform.DOMoveY(0f, loseAnimationDuration*2).From().SetEase(Ease.OutBounce).SetUpdate(true);
    }
    
    
    
    public void Win()
    {
        Time.timeScale = 0f;
        StartCoroutine(AnimateWinScreen());
    }

    private IEnumerator AnimateWinScreen()
    {
        Debug.Log(score);
        winScreenPanel.SetActive(true);
        scoreText.gameObject.SetActive(false);
        var originalColor = winScreenBG.color;
        originalColor.a = 0;
        winScreenBG.color = originalColor;
        winScreenBG.DOFade(1, winAnimationDuration).SetUpdate(true);
        yield return new WaitForSecondsRealtime(winAnimationDuration / 3);
        scoreText.gameObject.SetActive(true);
        scoreText.text = score.ToString();
        // scoreText.transform.DOScale(Vector3.zero, winAnimationDuration).From().SetEase(Ease.OutBack).SetUpdate(true);
        scoreText.transform.DOPunchScale(new Vector3(-1,-1,0), winAnimationDuration*2, 3, 3).SetUpdate(true);
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
