using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Animator animator;   // Animator 组件的引用
    public Rigidbody rb;        // Rigidbody 组件的引用
    public float torque = 10f;  // 旋转扭矩的大小
    public float waitTime = 2f; // 等待时间，之后重启动画



    // 动画事件调用此方法，启用物理控制
    public void EnablePhysics()
    {
        // 禁用 Animator 组件，停止动画控制
        animator.enabled = false;

        // 使 Rigidbody 可以受到物理影响
        rb.isKinematic = false;

        // 应用初始旋转扭矩
        ApplyTorqueAndForce();

        StartCoroutine(ReenableAnimatorAfterTime(waitTime)); // 等待一段时间后重启动画
    }

    // 应用扭矩和力
    void ApplyTorqueAndForce()
    {
        // 添加一个向上的力和一个旋转扭矩
        
        rb.AddTorque(Vector3.forward * torque, ForceMode.Impulse);
    }
    IEnumerator ReenableAnimatorAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        rb.isKinematic = true; // 重新使 Rigidbody 静态，停止受物理影响

        transform.localPosition = new Vector3(3.288931e-09f, 0.0881f, 0);  // 设定为动画开始时应有的位置
        transform.rotation = Quaternion.Euler(0, 0, 0);  // 设定为动画开始时应有的旋转

        yield return new WaitForSeconds(1f);
        animator.enabled = true; // 重启动画控制


        animator.CrossFade("Flying", 0.1f); // 从 Flying 状态开始播放动画
    }

}
