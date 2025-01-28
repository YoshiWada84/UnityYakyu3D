using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb1 : MonoBehaviour
    {
        
        [Header("������Prefab")] [SerializeField] private Explosion1 _explosionPrefab;
        public ballcontroll1 BC;
        private GameTextes1 gamas;
       

        void Update()
        {
            if (BC.hitBomb == true)
            {
                // ��莞�Ԍo�ߌ�ɔ���
                Invoke(nameof(Explode), 0);
                
               
            }
            if (gamas.change == true)
            {
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