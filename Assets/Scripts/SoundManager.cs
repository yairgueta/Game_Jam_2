using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    private AudioSource GameAudio;
    private AudioSource FlameSoundEffect;
    private AudioSource FireSoundEffect;

    private AudioClip GameSound;
    private AudioClip StartSound;

    protected override void Awake()
    {

        GameAudio = gameObject.AddComponent<AudioSource>();
        GameSound = Resources.Load<AudioClip>("Sounds/GameSound");
        StartSound = Resources.Load<AudioClip>("Sounds/StartSceneSoundtrack");
        GameAudio.clip = StartSound;

        FlameSoundEffect = gameObject.AddComponent<AudioSource>();
        FlameSoundEffect.clip = Resources.Load<AudioClip>("Sounds/FlameThrowerSoundEffect");

        FireSoundEffect = gameObject.AddComponent<AudioSource>();
        FireSoundEffect.clip = Resources.Load<AudioClip>("Sounds/FireballSoundEffect");



        FlameSoundEffect.loop = false;
        FireSoundEffect.loop = false;
        GameAudio.loop = true;

        FlameSoundEffect.playOnAwake = false;
        FireSoundEffect.playOnAwake = false;
        GameAudio.playOnAwake = true;
    }
    public enum Sound
    {
        FlameSound,
        FireBallSound,
        GameSound,
        StartSound
    }
    public void PlaySound(Sound sound)
    {
        switch (sound)
        {
            case Sound.FireBallSound:
                FireSoundEffect.Play();
                break;
            case Sound.FlameSound:
                FlameSoundEffect.Play();
                break;
            case Sound.GameSound:
                GameAudio.clip = GameSound;
                GameAudio.Play();
                break;
            case Sound.StartSound:
                GameAudio.clip = StartSound;
                GameAudio.Play();
                break;
        }
    }
    public void StopSound(Sound sound)
    {
        switch (sound)
        {
            case Sound.FireBallSound:
                FireSoundEffect.Stop();
                break;
            case Sound.FlameSound:
                FlameSoundEffect.Stop();
                break;
            case Sound.GameSound:
                GameAudio.Stop();
                break;
        }
    }
}
