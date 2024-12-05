using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private Explosion1 _explosionPrefab;
        public ballcontroll BC;
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