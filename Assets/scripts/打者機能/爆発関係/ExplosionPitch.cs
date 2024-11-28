using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExplosionSample
{
    public class ExplosionPitch : MonoBehaviour
    {
        
        
        [Header("�����ɓ��������Ƃ��ɐ�����ԗ͂̋���")]
        [SerializeField]
        private float _futtobiPower;

        [Header("�����̔��肪���ۂɔ�������܂ł̃f�B���C")]
        [SerializeField]
        private float _startDelaySeconds = 0.1f;

        [Header("�����̎����t���[����")] [SerializeField] private int _durationFrameCount = 1;

        [Header("�G�t�F�N�g�܂߂��ׂĂ̍Đ����I������܂ł̎���")]
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
        /// ���j����
        /// </summary>
        public void Explode()
        {
            // �����蔻��Ǘ��̃R���[�`��
            StartCoroutine(ExplodeCoroutine());
            // �����G�t�F�N�g�܂߂Ă������������R���[�`��
            StartCoroutine(StopCoroutine());

            // �G�t�F�N�g�ƌ��ʉ��Đ�
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

            
            _collider.enabled = true;//�����蔻�� on

            // �t���[�����L����
            for (var i = 0; i < _durationFrameCount; i++)
            {
                yield return new WaitForFixedUpdate();
            }

            // �����蔻�薳����
            _collider.enabled = false;
        }

        private IEnumerator StopCoroutine()
        {
            // ���Ԍo�ߌ�ɏ���
            yield return new WaitForSeconds(_stopSeconds);
            _effect.Stop();
            
            _collider.enabled = false;

            Destroy(gameObject);
        }

        /// <summary>
        /// �����Ƀq�b�g�����Ƃ��ɑ�����ӂ��Ƃ΂�����
        /// </summary>
        
    }
}