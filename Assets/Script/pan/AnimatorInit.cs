using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInit : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // ��������Ҫȷ���Ĳ���
        Debug.Log("init");
        animator.SetBool("True", true);
        animator.ResetTrigger("StartAnimation");
        // ���Լ�����Ӹ�����Ҫȷ����ȷ�Ĳ���
    }
}
