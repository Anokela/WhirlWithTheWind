using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> lightPointSoundList;
    private List<AudioClip> lightPointSounds;
    public AudioSource AudioSrc;
    private AudioClip lightPointHitSound;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        lightPointSounds = new List<AudioClip>();
        for (int i = 0; i < lightPointSoundList.Count; i++)
        {
            lightPointSounds.Add(lightPointSoundList[i]);
        }
    }
    // Update is called once per frame

    public void PlaySound()
    {
        index = Random.Range(0, lightPointSounds.Count);
        lightPointHitSound = lightPointSounds[index];
        AudioSrc.PlayOneShot(lightPointHitSound);
    }
}
