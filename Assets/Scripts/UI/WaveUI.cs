using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Wave;

public class WaveUI : MonoBehaviour
{
    [SerializeField] private TMP_Text waveNumberText;
    void Start()
    {
        WavesManager.Instance.onNewWaveStart.AddListener(NewWaveDisplay);
    }

    private void NewWaveDisplay(int waveNum)
    {
        waveNumberText.text = (waveNum + 1).ToString();
        waveNumberText.transform.DOPunchScale(Vector3.one * 1.2f, .5f, 1);
    }
    
}
