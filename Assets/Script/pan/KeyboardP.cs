using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardP : MonoBehaviour
{
    /*    // Start is called before the first frame update
        public Animator animator; // 将 Animator 组件拖到此字段
        public string triggerName = "StartAnimation"; // 触发器的名称

        void Update()
        {
            // 检测按键是否被按下
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (animator != null && !string.IsNullOrEmpty(triggerName))
                {
                    animator.SetTrigger(triggerName); // 设置触发器
                    Debug.Log($"Trigger '{triggerName}' activated by pressing P.");
                }
            }
        }*/
    public Animator animator; // Animator 组件
    public string triggerName = "StartAnimation"; // 触发器的名称
    public string targetTag = "Weapon"; // 碰撞对象的标签

    private void OnCollisionEnter(Collision collision)
    {
        // 检查是否与指定标签的物体碰撞
        if (collision.collider.CompareTag(targetTag))
        {
            if (animator != null && !string.IsNullOrEmpty(triggerName))
            {
                animator.SetTrigger(triggerName); // 设置触发器
                Debug.Log($"Trigger '{triggerName}' activated by collision with '{collision.collider.name}'.");
            }
        }
    }
}
