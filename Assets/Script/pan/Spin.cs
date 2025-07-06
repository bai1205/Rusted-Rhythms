using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Animator animator;   // Animator ���������
    public Rigidbody rb;        // Rigidbody ���������
    public float torque = 10f;  // ��תŤ�صĴ�С
    public float waitTime = 2f; // �ȴ�ʱ�䣬֮����������



    // �����¼����ô˷����������������
    public void EnablePhysics()
    {
        // ���� Animator �����ֹͣ��������
        animator.enabled = false;

        // ʹ Rigidbody �����ܵ�����Ӱ��
        rb.isKinematic = false;

        // Ӧ�ó�ʼ��תŤ��
        ApplyTorqueAndForce();

        StartCoroutine(ReenableAnimatorAfterTime(waitTime)); // �ȴ�һ��ʱ�����������
    }

    // Ӧ��Ť�غ���
    void ApplyTorqueAndForce()
    {
        // ���һ�����ϵ�����һ����תŤ��
        
        rb.AddTorque(Vector3.forward * torque, ForceMode.Impulse);
    }
    IEnumerator ReenableAnimatorAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        rb.isKinematic = true; // ����ʹ Rigidbody ��̬��ֹͣ������Ӱ��

        transform.localPosition = new Vector3(3.288931e-09f, 0.0881f, 0);  // �趨Ϊ������ʼʱӦ�е�λ��
        transform.rotation = Quaternion.Euler(0, 0, 0);  // �趨Ϊ������ʼʱӦ�е���ת

        yield return new WaitForSeconds(1f);
        animator.enabled = true; // ������������


        animator.CrossFade("Flying", 0.1f); // �� Flying ״̬��ʼ���Ŷ���
    }

}
