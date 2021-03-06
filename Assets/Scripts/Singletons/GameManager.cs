using DG.Tweening;
using Enemies;
using Hydra;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float mapLength = 100f;
    public UnityEvent<int> onScoreChange;

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
        var _ = SoundManager.Instance;
    }

    private void Start()
    {
        EnemiesManager.Instance.onEnemyDeath.AddListener((e) =>
        {
            score += e.Score;
            onScoreChange?.Invoke(score);
        });
    }

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

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(mapLength, 1, 0));
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, new Vector3(mapLength, .5f, 0));
    }
}
