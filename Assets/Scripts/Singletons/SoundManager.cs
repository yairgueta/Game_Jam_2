using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    private AudioSource GameAudio;
    private AudioSource FlameSoundEffect;

    private AudioSource SoundEffects;

    private AudioClip GameSound;
    private AudioClip StartSound;
    private AudioClip FireSoundEffect;
    private AudioClip buttonClickSoundEffect;
    private AudioClip GameOverSound;
    private AudioClip LoseHeadSound;
    private AudioClip WinGameSound;
    private AudioClip WinWaveSound;
    private AudioClip EnemyKillSound;

    protected override void Awake()
    {

        GameAudio = gameObject.AddComponent<AudioSource>();
        GameSound = Resources.Load<AudioClip>("Sounds/GameSound");
        StartSound = Resources.Load<AudioClip>("Sounds/StartSceneSoundtrack");

        FlameSoundEffect = gameObject.AddComponent<AudioSource>();
        FlameSoundEffect.clip = Resources.Load<AudioClip>("Sounds/FlameThrowerSoundEffect");

        SoundEffects = gameObject.AddComponent<AudioSource>();

        FireSoundEffect= Resources.Load<AudioClip>("Sounds/FireballSoundEffect");
        buttonClickSoundEffect= Resources.Load<AudioClip>("Sounds/ButtonClickSound");
        GameOverSound = Resources.Load<AudioClip>("Sounds/GameOverSound");
        LoseHeadSound = Resources.Load<AudioClip>("Sounds/LoseHeadSound");
        WinGameSound = Resources.Load<AudioClip>("Sounds/WinGameSound");
        WinWaveSound = Resources.Load<AudioClip>("Sounds/WinWaveSound");
        EnemyKillSound= Resources.Load<AudioClip>("Sounds/EnemyKill");

        FlameSoundEffect.loop = false;
        SoundEffects.loop = false;
        GameAudio.loop = true;

        FlameSoundEffect.playOnAwake = false;
        SoundEffects.playOnAwake = false;
        GameAudio.playOnAwake = true;

        base.Awake();
    }
    public enum Sound
    {
        FlameSound,
        FireBallSound,
        GameSound,
        StartSound,
        buttonSound,
        GameOverSound,
        LoseHeadSound,
        WinWaveSound,
        WinGameSound,
        EnemyKillSound

    }
    public void PlaySound(Sound sound)
    {
        switch (sound)
        {
            case Sound.FireBallSound:
                SoundEffects.PlayOneShot(FireSoundEffect,0.4f);
                break;
            case Sound.buttonSound:
                SoundEffects.PlayOneShot(buttonClickSoundEffect,0.1f);
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
            case Sound.LoseHeadSound:
                SoundEffects.PlayOneShot(LoseHeadSound,0.5f);
                break;
            case Sound.GameOverSound:
                SoundEffects.PlayOneShot(GameOverSound,0.2f);
                break;
            case Sound.WinGameSound:
                SoundEffects.PlayOneShot(WinGameSound, 0.2f);
                break;
            case Sound.WinWaveSound:
                SoundEffects.PlayOneShot(WinWaveSound, 0.3f);
                break;
            case Sound.EnemyKillSound:
                SoundEffects.PlayOneShot(EnemyKillSound, 0.5f);
                break;
        }
    }
    public void StopSound(Sound sound)
    {
        switch (sound)
        {
            case Sound.FireBallSound:
                SoundEffects.Stop();
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
