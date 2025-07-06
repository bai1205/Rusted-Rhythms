using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreloadAnime : MonoBehaviour
{
    public Animator animator; // 将 Animator 组件拖拽到 Inspector 中

    void Start()
    {
        StartCoroutine(DelayedAnimatorInitialization());
    }

    IEnumerator DelayedAnimatorInitialization()
    {
        yield return null; // 等待一帧

        if (animator != null)
        {
            animator.Rebind();
            animator.Update(0);
            Debug.Log("Animator initialized after one frame delay.");
        }
    }
}
