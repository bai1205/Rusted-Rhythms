using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardP : MonoBehaviour
{
    /*    // Start is called before the first frame update
        public Animator animator; // �� Animator ����ϵ����ֶ�
        public string triggerName = "StartAnimation"; // ������������

        void Update()
        {
            // ��ⰴ���Ƿ񱻰���
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (animator != null && !string.IsNullOrEmpty(triggerName))
                {
                    animator.SetTrigger(triggerName); // ���ô�����
                    Debug.Log($"Trigger '{triggerName}' activated by pressing P.");
                }
            }
        }*/
    public Animator animator; // Animator ���
    public string triggerName = "StartAnimation"; // ������������
    public string targetTag = "Weapon"; // ��ײ����ı�ǩ

    private void OnCollisionEnter(Collision collision)
    {
        // ����Ƿ���ָ����ǩ��������ײ
        if (collision.collider.CompareTag(targetTag))
        {
            if (animator != null && !string.IsNullOrEmpty(triggerName))
            {
                animator.SetTrigger(triggerName); // ���ô�����
                Debug.Log($"Trigger '{triggerName}' activated by collision with '{collision.collider.name}'.");
            }
        }
    }
}
