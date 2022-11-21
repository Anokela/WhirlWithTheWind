using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> lightPointSoundList;
    private List<AudioClip> lightPointSounds;
    private AudioClip lightPointHitSound;
    private int index;

    public AudioSource AudioSrc;

    public List<AudioClip> LeafHitSoundList;
    private List<AudioClip> LeafHitSounds;
    private AudioClip LeafHitSound;
    private int LeafHitIndex;

    // Start is called before the first frame update
    void Start()
    {
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

    public void PlaySound()
    {
        index = Random.Range(0, lightPointSounds.Count);
        lightPointHitSound = lightPointSounds[index];
        AudioSrc.PlayOneShot(lightPointHitSound);
    }

    public void LeafSound()
    {
        LeafHitIndex = Random.Range(0, LeafHitSounds.Count);
        LeafHitSound = LeafHitSounds[LeafHitIndex];
        AudioSrc.PlayOneShot(LeafHitSound);
    }
}
