//using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MyGame.DefGameBasic
{
    public class Enemy_Control : MonoBehaviour, IComponentChecking
    {
        public float speed;
        public float atkDistance;
        Animator m_anim;
        Rigidbody2D m_rb;
        Player_Control m_player;//Script player
        public GameObject en_gameObject;
        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindObjectOfType<Player_Control>();//tim kiem tren screen
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
            float disToPlayer = Vector2.Distance(m_player.transform.position, transform.position);
            if ( disToPlayer <= atkDistance)
            {
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_rb.velocity = Vector2.zero;
            }
            else
            {
                m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }
    }
}
