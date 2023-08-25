using MyGame.DefGameBasic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.DefGameBasic
{
    public class Weapon : MonoBehaviour, IComponentChecking
    {
        public GameObject m_gameObject;
        Animator m_anim;
        private bool en_dead;
        private void Awake()
        {
            m_anim = GetComponent<Animator>();
        }
        public bool IsComNull()
        {
            return m_anim == null;
        }
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (IsComNull()) return;
            if (col.CompareTag(Const.ENEMY_WEAPON_TAG))
            {
                m_anim.SetTrigger(Const.DEATH_ANIM);
                //Destroy(m_gameObject,3f);
                //en_dead = true;
            }
        }
    }

}
