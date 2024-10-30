using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch : MonoBehaviour
    {
        
        [Header("”š•—‚ÌPrefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.pitch == true)
            {
                // ˆê’èŠÔŒo‰ßŒã‚É”­‰Î
                Invoke(nameof(Explode), 0);
                
               
            }
            
        }

        private void Explode()
        {
            // ”š”­‚ğ¶¬
            var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.Explode();

            // ©g‚ÍÁ‚¦‚é
            this.gameObject.SetActive(false);
        }
    }
}