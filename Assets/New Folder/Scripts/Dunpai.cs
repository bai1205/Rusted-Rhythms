using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dunpai : MonoBehaviour
{
    AudioSource audioSource;
    public ParticleSystem part;
    public ParticleSystem texiao;
    float time = 1f;
    bool playing = false;
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
    private void FixedUpdate()
    {
        if (playing)
        {
            time -= 0.02f;
            if (time <= 0)
            {
                texiao.Stop();
                texiao.gameObject.SetActive(false);
                time = 1f;
                playing = false;
            }
        }
    }
    public void Play()
    {
        playing = true;
        time = 1f;
        audioSource.Play();
        part.gameObject.SetActive(true);
        part.Play();
        texiao.gameObject.SetActive(true);
        texiao.Play();

    }
}
