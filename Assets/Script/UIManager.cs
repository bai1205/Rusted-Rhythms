using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar speedScrollbar; // 滚动条控件

    void Start()
    {
        if (speedScrollbar != null)
        {
            // 为滚动条添加监听事件
            speedScrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);

            // 初始化滚动条位置（可选）
            speedScrollbar.value = 0.5f; // 默认从正常速度开始
        }
    }
    public void Reset()
    {
        AudioManager.Instance.StopMusic();
        Debug.Log("Stop Music");
        
    }
    private void OnScrollbarValueChanged(float value)
    {
        // 调用 AudioManager 更新所有音效速度
        AudioManager.Instance.SetAllMusicSpeed(value);
    }

}
