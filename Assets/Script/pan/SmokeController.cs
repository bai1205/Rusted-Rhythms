using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyWok.ParticleManager;

public class SmokeController : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem smokeEffect;
    public ParticleManager particleManager; // �� Inspector ����ק ParticleManager ��������

    public void StartSmoke()
    {
        smokeEffect.Play();
    }

    public void StopSmoke()
    {
        smokeEffect.Stop();
    }

    public void ChangeParticleSystem(int index)
    {
        ParticleSystem ps = particleManager.GetParticleSystem(index);
        if (ps != null)
        {
            smokeEffect = ps;
        }
    }
}
