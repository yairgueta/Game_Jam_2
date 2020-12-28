using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    private static AudioSource GameAudio;
    private static AudioSource FlameSoundEffect;

    private static AudioSource SoundEffects;

    private static AudioClip GameSound;
    private static AudioClip StartSound;
    private static AudioClip FireSoundEffect;
    private static AudioClip buttonClickSoundEffect;
    private static AudioClip GameOverSound;
    private static AudioClip LoseHeadSound;
    private static AudioClip WinGameSound;
    private static AudioClip WinWaveSound;
    private static AudioClip EnemyKillSound;

    protected override void Awake()
    {
        base.Awake();
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

    public void PlaySound(string sound)
    {
        Sound.TryParse(sound, true, out Sound soundEn);
        if (soundEn == default)
        {
            Debug.LogWarning(sound + " is not a valid sound!");
            return;
        }
        PlaySound(soundEn);
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
    
    public void StopSound(string sound)
    {
        Sound.TryParse(sound, true, out Sound soundEn);
        if (soundEn == default)
        {
            Debug.LogWarning(sound + " is not a valid sound!");
            return;
        }
        StopSound(soundEn);
    }
}
