using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb1 : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private Explosion _explosionPrefab;
        public ballcontroll1 BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.hitBomb == true)
            {
                // ��莞�Ԍo�ߌ�ɔ���
                Invoke(nameof(Explode), 0);
                BC.hitBomb = false;
               
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