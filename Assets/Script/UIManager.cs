using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar speedScrollbar; // �������ؼ�

    void Start()
    {
        if (speedScrollbar != null)
        {
            // Ϊ��������Ӽ����¼�
            speedScrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);

            // ��ʼ��������λ�ã���ѡ��
            speedScrollbar.value = 0.5f; // Ĭ�ϴ������ٶȿ�ʼ
        }
    }
    public void Reset()
    {
        AudioManager.Instance.StopMusic();
        Debug.Log("Stop Music");
        
    }
    private void OnScrollbarValueChanged(float value)
    {
        // ���� AudioManager ����������Ч�ٶ�
        AudioManager.Instance.SetAllMusicSpeed(value);
    }

}
