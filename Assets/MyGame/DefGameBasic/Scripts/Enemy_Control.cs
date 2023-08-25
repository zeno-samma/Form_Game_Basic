using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.DefGameBasic
{
    public class Enemy_Cotrol : MonoBehaviour
    {
        public float speed;
        public float atkDistance;
        Animator m_anim;
        Rigidbody2D m_rb;
        Player_Control m_player;//Script player

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

        // Update is called once per frame
        void Update()
        {
            if (m_player == null || m_rb == null )return;
            if (Vector2.Distance(m_player.transform.position, transform.position) <= atkDistance)
            { 
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_rb.velocity = Vector2.zero;
            }else
            {
               m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }
    }
}
