using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guitar : MonoBehaviour
{
    AudioSource audioSource;
    public ParticleSystem part;
    public ParticleSystem texiao;
    private void OnTriggerEnter(Collider other)
    {
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
            texiao.gameObject.SetActive(false);
        }
        else
        {

            audioSource.Play();
            part.gameObject.SetActive(true);
            texiao.gameObject.SetActive(true);
            part.Play();
            texiao.Play();
        }
    }
}
