using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ExplosionSample
{
    public class Bomb : MonoBehaviour
    {
        
        [Header("”š•—‚ÌPrefab")] [SerializeField] private Explosion _explosionPrefab;

        private void Start()
        {
            // ˆê’èŠÔŒo‰ßŒã‚É”­‰Î
            Invoke(nameof(Explode),0);
        }

        private void Explode()
        {
            // ”š”­‚ğ¶¬
            var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            explosion.Explode();

            // ©g‚ÍÁ‚¦‚é
            Destroy(gameObject);
        }
    }
}