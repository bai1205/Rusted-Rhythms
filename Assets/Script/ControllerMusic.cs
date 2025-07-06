using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerMusic : MonoBehaviour
{
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
            case "Wood":
                AudioManager.Instance.PlayMusic(0);  // ��������Ϊ 0 ����Ч
                break;

            case "Mental":
                AudioManager.Instance.PlayMusic(1);  // ��������Ϊ 1 ����Ч
                break;
            case "Juice":
                AudioManager.Instance.PlayMusic(2);
                break;
            case "BeerrBottle":
                AudioManager.Instance.PlayMusic(3);
                break;
            case "Soda":
                AudioManager.Instance.PlayMusic(4);
                break;
            case "GinBottle":
                AudioManager.Instance.PlayMusic(5);
                break;
            case "Floor":
                AudioManager.Instance.PlayMusic(6);
                break;
            default:
                // �����Ĭ����������߼��������Ҫ��
                break;
        }


    }

}
