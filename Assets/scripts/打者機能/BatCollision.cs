using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ExplosionSample
{
    public class BatCollision : MonoBehaviour
    {

        //private float bounce = 10f;
        [Header("îöïóÇÃPrefab")] [SerializeField] private Explosion _explosionPrefab;
        public GameObject batbat;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter(Collision collision)
        {
            //collision.rigidbody.AddForce(-bounce, 0f, 0f, ForceMode.Impulse);
            if (collision.gameObject.tag == "Ball")
            {
                // îöî≠Çê∂ê¨
                var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
                explosion.Explode();

            }
        }
    }
}