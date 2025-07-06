using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class AnimatorInspectorRefresher : MonoBehaviour
{
    public Animator animator; // �� Inspector ������Ŀ�� Animator

    void Start()
    {
        ForceInspectorTrigger();
    }

    void ForceInspectorTrigger()
    {
#if UNITY_EDITOR
        EditorUtility.SetDirty(animator); // ģ�� Inspector �е�ˢ��
        Debug.Log("Manually triggered Inspector-like refresh.");
#endif
    }
}
