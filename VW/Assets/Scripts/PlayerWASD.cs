using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : MonoBehaviour {
    

    public int speed = 0;
    public int rotSpeed = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Vertical")!=0)
        {
            float _translate = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, 0, _translate);
        }
        if (Input.GetAxis("Horizontal")!=0)
        {
            float _rotation = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.Rotate(0, _rotation, 0);
        }

	}
}
