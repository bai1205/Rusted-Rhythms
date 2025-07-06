using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyWok.ParticleManager
{
    public class ParticleManager : MonoBehaviour
    {
        public ParticleSystem[] particleSystems; // �� Inspector ����ק����ϵͳ���������

        // ͨ���ű���ȡ�ض�����ϵͳ�ķ���
        public ParticleSystem GetParticleSystem(int index)
        {
            if (index >= 0 && index < particleSystems.Length)
            {
                return particleSystems[index];
            }
            return null;
        }
    }
}
