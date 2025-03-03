using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionSample
{
    public class BatCollisionCPU : MonoBehaviour
    {
        [Header("爆風のPrefab")] [SerializeField] private Explosion _explosionPrefab;
        //private float bounce = 10f;
        public ballcontroll ball;
        public batCPU bat;
        public GameObject batbat;
        public GameTextes gamas;

        
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
            if (gamas.game == false)
            {
                if (collision.gameObject.tag == "Ball" && ball.hitBomb == false && ((gamas.Runner + 1 > gamas.AtkPt - gamas.DefPt && 3 <= gamas.Inning) || gamas.Out == 2) && !Input.GetMouseButton(1))
                {
                    bat.hit = true;
                    ball.hitBomb = true;
                }
                else if (collision.gameObject.tag == "Ball")
                {
                    bat.hit = true;
                    // 爆発を生成
                    var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
                    explosion.Explode();
                }
            }
            else if (gamas.game == true)
            {
                if (collision.gameObject.tag == "Ball" && ball.hitBomb == false && ((gamas.Runner + 1 > gamas.AtkPt - gamas.DefPt && 9 <= gamas.Inning) || gamas.Out == 2) && !Input.GetMouseButton(1))
                {
                    bat.hit = true;
                    ball.hitBomb = true;
                }
                else if (collision.gameObject.tag == "Ball")
                {
                    bat.hit = true;
                    // 爆発を生成
                    var explosion = Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
                    explosion.Explode();
                }
            }
        }
    }
}