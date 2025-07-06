using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager Instance;
    public AudioSource[] soundEffectSources;  // 音效的 AudioSource 数组
    private void Awake()
    {
        // 确保只存在一个 AudioManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // 保证该对象在场景切换时不会销毁
        }
        else
        {
            Destroy(gameObject);  // 如果已有实例，销毁当前对象
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
        float speed = Mathf.Lerp(0.5f, 2.0f, scrollbarValue); // 将滚动条值映射到播放速度范围
        foreach (var soundEffectSource in soundEffectSources)
        {
            if (soundEffectSource != null)
            {
                soundEffectSource.pitch = speed;
            }
        }
    }


}
