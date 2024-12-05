using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionSample
{
    public class BatCollisionCPU1 : MonoBehaviour
    {
        [Header("”š•—‚ÌPrefab")] [SerializeField] private Explosion _explosionPrefab;
        //private float bounce = 10f;
        public ballcontroll1 ball;
        public batTBCPU bat;
        public GameObject batbat;
        public GameTimeBase gamas;
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
            if (collision.gameObject.tag == "Ball" && ball.hitBomb == false && ((gamas.Runner + 1 > gamas.AtkPt - gamas.DefPt && 3 <= gamas.Inning) || gamas.Out == 1))
            {
                bat.hit = true;
                ball.hitBomb = true;
            }
            else if (collision.gameObject.tag == "Ball")
            {
                bat.hit = true;
                // ”š”­‚ð¶¬
                var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
                explosion.Explode();
            }
        }
    }
}