using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MyGame.DefGameBasic
{
    public class Game_Lib : MonoBehaviour
    {
        public Transform myTransform;
        public void Awake()
        {
            Debug.Log("Awake");
        }
        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Start");
            myTransform.position = new Vector3(5, 0, 0);
            //Debug.Log(gameObject.tag);
        }
        private void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}