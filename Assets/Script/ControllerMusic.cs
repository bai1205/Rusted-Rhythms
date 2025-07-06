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
                AudioManager.Instance.PlayMusic(0);  // 播放索引为 0 的音效
                break;

            case "Mental":
                AudioManager.Instance.PlayMusic(1);  // 播放索引为 1 的音效
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
                // 可添加默认情况处理逻辑（如果需要）
                break;
        }


    }

}
