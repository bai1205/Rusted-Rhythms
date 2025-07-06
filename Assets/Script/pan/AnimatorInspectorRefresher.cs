using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class AnimatorInspectorRefresher : MonoBehaviour
{
    public Animator animator; // 在 Inspector 中拖入目标 Animator

    void Start()
    {
        ForceInspectorTrigger();
    }

    void ForceInspectorTrigger()
    {
#if UNITY_EDITOR
        EditorUtility.SetDirty(animator); // 模拟 Inspector 中的刷新
        Debug.Log("Manually triggered Inspector-like refresh.");
#endif
    }
}
