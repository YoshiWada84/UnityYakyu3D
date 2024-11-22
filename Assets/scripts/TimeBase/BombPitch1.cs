using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch1 : MonoBehaviour
    {
        
        [Header("”š•—‚ÌPrefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll1 BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.pitch == true)
            {
                // ˆê’èŠÔŒo‰ßŒã‚É”­‰Î
                Invoke(nameof(Explode), 0);
                BC.pitch = false;
               
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