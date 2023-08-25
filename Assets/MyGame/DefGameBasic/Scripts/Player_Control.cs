using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
namespace MyGame.DefGameBasic
{
    public class Player_Control : MonoBehaviour, IComponentChecking
    {
        public float atkRate;
        private Animator m_anim;
        private float m_curAtkRate;
        private bool m_isCanAtk;
        public GameObject pl_gameObject;
        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        public bool IsComNull()
        {
            return m_anim == null;
        }

        // Update is called once per frame
        void Update()
        {
            if (IsComNull()) return;

            //Debug.Log(m_isCanAtk);
            if (Input.GetMouseButtonDown(0) && !m_isCanAtk)
            {
                    m_anim.SetBool(Const.ATTACK_ANIM, true);
                    m_isCanAtk = true;
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
            if (IsComNull()) return;
            m_anim.SetBool(Const.ATTACK_ANIM, false);
        }
    }
}