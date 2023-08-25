using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MyGame.DefGameBasic
{
    public class Player : MonoBehaviour
    {
        public float atkRate;
        private Animator m_anim;
        private float m_curAtkRate;
        private bool m_isCanAtk;

        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
        }



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Debug.Log(m_isCanAtk);
            if (Input.GetMouseButtonDown(0) && !m_isCanAtk)
            {
                if (m_anim)
                {
                    m_anim.SetBool(Const.ATTACK_ANIM, true);
                    m_isCanAtk = true;
                }

            }
            if (m_isCanAtk)
            {
                m_curAtkRate -= Time.deltaTime;
                if (m_curAtkRate <= 0)
                {
                    m_isCanAtk = false;
                    m_curAtkRate = atkRate;
                }
            }
        }
        public void ResetAtkAnim()
        {
            if (m_anim)
                m_anim.SetBool(Const.ATTACK_ANIM, false);
        }
    }
}