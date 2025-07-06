using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreloadAnime : MonoBehaviour
{
    public Animator animator; // �� Animator �����ק�� Inspector ��

    void Start()
    {
        StartCoroutine(DelayedAnimatorInitialization());
    }

    IEnumerator DelayedAnimatorInitialization()
    {
        yield return null; // �ȴ�һ֡

        if (animator != null)
        {
            animator.Rebind();
            animator.Update(0);
            Debug.Log("Animator initialized after one frame delay.");
        }
    }
}
