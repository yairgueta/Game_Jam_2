using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Wave;

public class WaveUI : MonoBehaviour
{
    [SerializeField] private TMP_Text waveNumberText;
    [SerializeField] private TMP_Text scoreNumberText;

    private Tweener scoreTween;
    void Start()
    {
        WavesManager.Instance.onNewWaveStart.AddListener(NewWaveDisplay);
        GameManager.Instance.onScoreChange.AddListener(ScoreChange);
    }

    private void NewWaveDisplay(int waveNum)
    {
        waveNumberText.text = (waveNum + 1).ToString();
        waveNumberText.transform.DOPunchScale(Vector3.one * 1.2f, .5f, 1);
    }

    private void ScoreChange(int score)
    {
        scoreNumberText.text = score.ToString();
        if (scoreTween !=  null && !scoreTween.IsComplete())
        {
            scoreTween.Kill();
            scoreNumberText.transform.localScale = Vector3.one;
        }

        scoreTween = scoreNumberText.transform.DOPunchScale(Vector3.one * 1.2f, .5f, 1).ChangeStartValue(Vector3.one);
    }
    
}
