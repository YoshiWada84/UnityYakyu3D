using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ExplosionSample
{
    public class BatCollision : MonoBehaviour
    {

        //private float bounce = 10f;
        [Header("������Prefab")] [SerializeField] private Explosion _explosionPrefab;
        public GameObject batbat;//�o�b�g
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
            if (collision.gameObject.tag == "Ball")//�{�[���ɓ��������ꍇ
            {
                // �����𐶐�
                var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
                explosion.Explode();

            }
        }
    }
}