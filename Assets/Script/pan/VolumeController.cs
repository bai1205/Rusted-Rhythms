using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioPrefab;

    public void PlaySound(AudioClip clip)
    {
        AudioSource newAudio = Instantiate(audioPrefab, transform.position, Quaternion.identity);
        newAudio.clip = clip;
        newAudio.Play();
        Destroy(newAudio.gameObject, clip.length);  
    }
}
