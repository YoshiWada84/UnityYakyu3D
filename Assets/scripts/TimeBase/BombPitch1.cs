using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch1 : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll1 BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.pitch == true)
            {
                // ��莞�Ԍo�ߌ�ɔ���
                Invoke(nameof(Explode), 0);
                BC.pitch = false;
               
            }
            
        }

        private void Explode()
        {
            // �����𐶐�
            var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.Explode();

            // ���g�͏�����
            this.gameObject.SetActive(false);
        }
    }
}