using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInit : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // 设置你需要确保的参数
        Debug.Log("init");
        animator.SetBool("True", true);
        animator.ResetTrigger("StartAnimation");
        // 可以继续添加更多需要确保正确的参数
    }
}
