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
        public bool bomberman = false;
       

        void Update()
        {
            if (ballcontroll.shootSwitch == false && BC.pitch == false&&BC.hitter==false)
            {
                // 一定時間経過後に発火
                Invoke(nameof(Explode), 0);
                BC.pitch = true;
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