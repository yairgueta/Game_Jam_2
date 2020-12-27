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
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float mapLength = 100f;

    [Header("End Game References")] 
    [SerializeField] private UnityEvent onWin, onLose;
    [SerializeField] private GameObject endScreenPanel;
    [SerializeField] private Image endScreenBG;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float animationDuration;

    [SerializeField] private Sprite loseBG, winBG;

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
        onLose?.Invoke();
        endScreenBG.sprite = loseBG;
        AnimateEndScreen();
    }
    

    public void Win()
    {
        onWin?.Invoke();
        endScreenBG.sprite = winBG;
        AnimateEndScreen();
    }
    
    private void AnimateEndScreen()
    {
        Time.timeScale = 0f;
        scoreText.text = score.ToString();
        scoreText.gameObject.SetActive(false);
        endScreenPanel.SetActive(true);
        DOTween.Sequence().Insert(0, endScreenBG.transform.DOScale(Vector3.zero, animationDuration).From().SetEase(Ease.OutBack))
            .Insert(animationDuration/3, scoreText.transform.DOMoveY(0, 2 * animationDuration / 3).From().SetEase(Ease.OutBack).OnPlay(() => scoreText.gameObject.SetActive(true)))
            .SetUpdate(true);
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
