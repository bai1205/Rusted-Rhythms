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
        // ������Ч
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // ʵ��������ƿ��Ԥ����
        GameObject brokenBottle = Instantiate(brokenBottlePrefab, this.transform.position, Quaternion.identity);
        if (brokenBottle.TryGetComponent(out BrokenBottle brokenBottleScript))
        {
            brokenBottleScript.RandomVelocities();
        }

        // ���ٵ�ǰƿ��
        Destroy(gameObject);
    }
}
