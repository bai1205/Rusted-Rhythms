using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyWok.ParticleManager
{
    public class ParticleManager : MonoBehaviour
    {
        public ParticleSystem[] particleSystems; // 在 Inspector 中拖拽粒子系统到这个数组

        // 通过脚本获取特定粒子系统的方法
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
