using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class BombPitch1 : MonoBehaviour
    {
        
        [Header("”š•—‚ÌPrefab")] [SerializeField] private ExplosionPitch _explosionPrefab;
        public ballcontroll1 BC;
        private GameTextes1 gamas;
        public bool bomberman = false;
       

        void Update()
        {
            if (ballcontroll.shootSwitch == false && BC.pitch == false&&BC.hitter==false)
            {
                // ˆê’èŠÔŒo‰ßŒã‚É”­‰Î
                Invoke(nameof(Explode), 0);
                BC.pitch = true;
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