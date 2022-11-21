using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> lightPointSoundList;
    private List<AudioClip> lightPointSounds;
    
    public  AudioSource lightPointAudioSource;
    private AudioClip lightPointHitSound;
    private int index;
    public AudioMixer audioMixer;
    public AudioSource intro;
    public AudioSource loopingAudio1;
    public AudioSource loopingAudio2;
    public AudioSource loopingAudio3;
    public AudioSource endingNoMel;
    public AudioSource endingNormal;
    private AudioSource ending;
    private AudioSource loopingAudio;
    private bool isLooping;
    private bool isLooping2;
    private bool isLooping3;
    private bool isEndingPlaying;


    // public AudioMixerSnapshot gameSnapshot;
    // public AudioMixerSnapshot pauseSnapshot;
    public AudioSource AudioSrc;
    public List<AudioClip> LeafHitSoundList;
    private List<AudioClip> LeafHitSounds;
    private AudioClip LeafHitSound;
    private int LeafHitIndex;

    // Start is called before the first frame update
    void Start()
    {
        ending = endingNoMel;
        loopingAudio = loopingAudio1;
        PlayerInfo.StopLoopingAudio = false;
        lightPointSounds = new List<AudioClip>();
        for (int i = 0; i < lightPointSoundList.Count; i++)
        {
            lightPointSounds.Add(lightPointSoundList[i]);
        }

        LeafHitSounds = new List<AudioClip>();
        for (int i = 0; i < LeafHitSoundList.Count; i++)
        {
            LeafHitSounds.Add(LeafHitSoundList[i]);
        }


    }



    // Update is called once per frame

    public void PlayLightPointSound()
    {
        index = Random.Range(0, lightPointSounds.Count);
        lightPointHitSound = lightPointSounds[index];
        lightPointAudioSource.PlayOneShot(lightPointHitSound);
    }

    void  FixedUpdate()
    {
        if (!intro.isPlaying && !isLooping && !isEndingPlaying)
        {
            loopingAudio.loop = true;
            loopingAudio.Play();
            isLooping = true;
        }
        if (PlayerInfo.Distance > 600 && !isLooping2)
        {
            loopingAudio.loop = false;
            if(!loopingAudio.isPlaying )
            {
                ending = endingNormal;
                loopingAudio = loopingAudio2;
                loopingAudio.Play();
                loopingAudio.loop = true;
                isLooping2 = true;
            }
            
        }
        if (PlayerInfo.Distance > 1100 && !isLooping3)
        {
            loopingAudio.loop = false;
            if (!loopingAudio.isPlaying)
            {
                loopingAudio = loopingAudio3;
                loopingAudio.Play();
                loopingAudio.loop = true;
                isLooping3 = true;
            }

        }
        if (PlayerInfo.StopLoopingAudio && !isEndingPlaying)
        {
            intro.Stop();
            loopingAudio.loop = false;
            loopingAudio.Stop();
            ending.Play();
            isEndingPlaying = true;
        }
    }

    public void LeafSound()
    {
        LeafHitIndex = Random.Range(0, LeafHitSounds.Count);
        LeafHitSound = LeafHitSounds[LeafHitIndex];
        AudioSrc.PlayOneShot(LeafHitSound);
    }
}
