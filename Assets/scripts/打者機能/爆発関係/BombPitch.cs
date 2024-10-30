using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.pitch == true)
            {
                // ��莞�Ԍo�ߌ�ɔ���
                Invoke(nameof(Explode), 0);
                
               
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