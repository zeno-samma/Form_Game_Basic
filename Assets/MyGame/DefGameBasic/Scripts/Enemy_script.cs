using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;
namespace MyGame.DefGameBasic
{
    public class Enemy_script : MonoBehaviour
    {
        //public GameObject heroPrefab;//Get ob
        //public SpriteRenderer sp;
        public Transform trans;
        float score;
        //public Enemy_script enemyScript;
        [Range(0f, 1f)]
        public float timeScaleValue = 1f;
        float angle = 0f;
        // Start is called before the first frame update
        void Start()
        {
            //if (heroPrefab)
            //{

            //    var enemyClone = Instantiate(heroPrefab, new Vector3(2f, 0, 0), Quaternion.identity);

            //    //Destroy(enemyClone, 3f);//Destroy after 3s.
            //}
            //if (sp)
            //{
            //    sp.color = Color.red;
            //}
            //Xu ly nhieu buoc
            //StartCoroutine(DemoCo()); //Hoac StartCoroutine("DemoCo");
            //Invoke("Work", 3);

            //==========================Luu diem cua nguoi choi khi thoat game
            score = PlayerPrefs.GetFloat("score", 0);
            score += 10;
            PlayerPrefs.SetFloat("score", score);
            Debug.Log(score);
        }

        //private IEnumerator DemoCo()//Xu ly nhieu buoc
        //{
        //    yield return new WaitForSeconds(3);
        //    Debug.Log("Xu ly cong viec 1");
        //    yield return new WaitForSeconds(3);
        //    Debug.Log("Xu ly cong viec 2");
        //}



        private void Work()
        {
            Debug.Log("Lam viec 1");
        }
        // Update is called once per frame
        void Update()
        {
            //====TimeScale la thuoc tinh Nhanh cham cua dong thoi gian
            Time.timeScale = timeScaleValue;
            angle += 1000 * timeScaleValue;
            if (trans)
            {
                trans.localRotation = Quaternion.Euler(0f, 0f, angle);
            }
        }

        //private void OnCollisionEnter2D(Collision2D colTarget)
        //{
        //    //Debug.Log("Da va cham voi nhau");
        //    //Debug.Log(colTarget.gameObject.tag);
        //}
        //private void OnTriggerEnter2D(Collider2D colTarget)
        //{
        //    //Debug.Log("Da va cham voi nhau");
        //}
        //private void OnCollisionStay(Collision colTarget)
        //{
        //    //Debug.Log("2 doi tuong dang va cham voi nhau");
        //}
        //private void OnTriggerStay(Collider other)
        //{
        //    //Debug.Log("2 doi tuong dang va cham voi nhau");
        //}

        //private void OnCollisionExit2D(Collision2D collision)
        //{
        //    //Debug.Log("2 doi tuong khong con va cham voi nhau");
        //}

        //private void OnTriggerExit2D(Collider2D collision)
        //{
        //    //Debug.Log("2 doi tuong khong con va cham voi nhau");
        //}
    }

}
