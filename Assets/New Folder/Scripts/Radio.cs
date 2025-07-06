using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    AudioSource audioSource;
    public ParticleSystem part;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(555);
        if (other.tag == "Player")
        {
            Play();
        }
    }
    private void Awake()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }
    public void Play()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
            part.gameObject.SetActive(false);
        }
        else
        {
            audioSource.Play();
            part.gameObject.SetActive(true);
            part.Play();
        }
    }
}
