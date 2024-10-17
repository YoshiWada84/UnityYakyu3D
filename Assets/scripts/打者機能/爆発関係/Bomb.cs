using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private Explosion _explosionPrefab;

        private void Start()
        {
            // ��莞�Ԍo�ߌ�ɔ���
            Invoke(nameof(Explode),0);
        }

        private void Explode()
        {
            // �����𐶐�
            var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.Explode();

            // ���g�͏�����
            Destroy(gameObject);
        }
    }
}