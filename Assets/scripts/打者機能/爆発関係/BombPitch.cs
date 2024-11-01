using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch : MonoBehaviour
    {
        
        [Header("爆風のPrefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.pitch == true)
            {
                // 一定時間経過後に発火
                Invoke(nameof(Explode), 0);
                
               
            }
            
        }

        private void Explode()
        {
            // 爆発を生成
            var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.Explode();

            // 自身は消える
            this.gameObject.SetActive(false);
        }
    }
}