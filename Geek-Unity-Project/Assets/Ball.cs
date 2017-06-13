using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

        private float speed = 13.0f;    //Ball速度調整

        // Use this for initialization
        void Start()
        {

            this.GetComponent<Rigidbody>().AddForce(    //RigidbodyはUnity側で実装確認
                (transform.forward + transform.right) * speed,
                ForceMode.VelocityChange);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }