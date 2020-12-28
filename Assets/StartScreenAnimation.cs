using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartScreenAnimation : MonoBehaviour
{
    [SerializeField] private UnityEvent onAnimationEnd;
    [SerializeField] private VideoPlayer videoPlayer;

    private RawImage animationScreen;

    private void Start()
    {
        animationScreen = GetComponent<RawImage>();
    }

    public void StartAnimation()
    {
        videoPlayer.Play();
        StartCoroutine(StartAnimation_Coroutine());
    }

    public IEnumerator StartAnimation_Coroutine()
    {
        videoPlayer.Play();
        Invoke(nameof(AnimationEnd), (float)videoPlayer.clip.length);
        yield return new WaitForSeconds(0.05f);
        animationScreen.enabled = true;
    }

    private void AnimationEnd()
    {
        onAnimationEnd?.Invoke();
    }
    
}
