using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollsion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        Collider other = collision.collider;
        switch (other.tag)
        {
            case "Floor":
                AudioManager.Instance.PlayMusic(6);
                break;
            default:
                // �����Ĭ����������߼��������Ҫ��
                break;
        }
    }
}