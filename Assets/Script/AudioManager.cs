using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager Instance;
    public AudioSource[] soundEffectSources;  // ��Ч�� AudioSource ����
    private void Awake()
    {
        // ȷ��ֻ����һ�� AudioManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // ��֤�ö����ڳ����л�ʱ��������
        }
        else
        {
            Destroy(gameObject);  // �������ʵ�������ٵ�ǰ����
        }
    }

    public void PlayMusic(int index)
    {
        if (index >= 0 && index < soundEffectSources.Length && soundEffectSources[index] != null)
        {
            soundEffectSources[index].Play();
        }
    }
    public void StopMusic()
    {
        foreach (var soundEffectSource in soundEffectSources)
        {
            if (soundEffectSource != null)
            {
                soundEffectSource.Stop();
            }
        }
    }
    public void SetAllMusicSpeed(float scrollbarValue)
    {
        float speed = Mathf.Lerp(0.5f, 2.0f, scrollbarValue); // ��������ֵӳ�䵽�����ٶȷ�Χ
        foreach (var soundEffectSource in soundEffectSources)
        {
            if (soundEffectSource != null)
            {
                soundEffectSource.pitch = speed;
            }
        }
    }


}
