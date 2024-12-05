using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb : MonoBehaviour
    {
        
        [Header("”š•—‚ÌPrefab")] [SerializeField] private Explosion1 _explosionPrefab;
        public ballcontroll BC;
        private GameTextes gamas;
       

        void Update()
        {
            if (BC.hitBomb == true)
            {
                // ˆê’èŠÔŒo‰ßŒã‚É”­‰Î
                Invoke(nameof(Explode), 0);
                BC.hitBomb = false;
               
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