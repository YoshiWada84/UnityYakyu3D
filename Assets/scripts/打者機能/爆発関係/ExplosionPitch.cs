using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionSample
{
    public class ExplosionPitch : MonoBehaviour
    {
        
        
        [Header("爆風に当たったときに吹っ飛ぶ力の強さ")]
        [SerializeField]
        private float _futtobiPower;

        [Header("爆風の判定が実際に発生するまでのディレイ")]
        [SerializeField]
        private float _startDelaySeconds = 0.1f;

        [Header("爆風の持続フレーム数")] [SerializeField] private int _durationFrameCount = 1;

        [Header("エフェクト含めすべての再生が終了するまでの時間")]
        [SerializeField]
        private float _stopSeconds = 2f;

        [SerializeField] private ParticleSystem _effect;

        

        [SerializeField] private SphereCollider _collider;

        private void Awake()
        {
            _effect.Stop();
           
            _collider.enabled = false;
        }

        /// <summary>
        /// 爆破する
        /// </summary>
        public void Explode()
        {
            // 当たり判定管理のコルーチン
            StartCoroutine(ExplodeCoroutine());
            // 爆発エフェクト含めてもろもろを消すコルーチン
            StartCoroutine(StopCoroutine());

            // エフェクトと効果音再生
            _effect.Play();
            
            
        }

        private IEnumerator ExplodeCoroutine()
        {
            
            var delayCount = Mathf.Max(0, _startDelaySeconds);
            while (delayCount > 0)
            {
                yield return new WaitForFixedUpdate();
                delayCount -= Time.fixedDeltaTime;
            }

            
            _collider.enabled = true;//当たり判定 on

            // フレーム数有効化
            for (var i = 0; i < _durationFrameCount; i++)
            {
                yield return new WaitForFixedUpdate();
            }

            // 当たり判定無効化
            _collider.enabled = false;
        }

        private IEnumerator StopCoroutine()
        {
            // 時間経過後に消す
            yield return new WaitForSeconds(_stopSeconds);
            _effect.Stop();
            
            _collider.enabled = false;

            Destroy(gameObject);
        }

        /// <summary>
        /// 爆風にヒットしたときに相手をふっとばす処理
        /// </summary>
        
    }
}