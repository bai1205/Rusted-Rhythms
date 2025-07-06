using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField] GameObject brokenBottlePrefab;
    AudioSource audioSource;
    public ParticleSystem part;

    private void Awake()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            Explode();
        }
    }

    public void Explode()
    {
        // 播放音效
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // 实例化破碎瓶子预制体
        GameObject brokenBottle = Instantiate(brokenBottlePrefab, this.transform.position, Quaternion.identity);
        if (brokenBottle.TryGetComponent(out BrokenBottle brokenBottleScript))
        {
            brokenBottleScript.RandomVelocities();
        }

        // 销毁当前瓶子
        Destroy(gameObject);
    }
}
