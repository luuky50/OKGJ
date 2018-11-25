using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour {
    public GameObject enemy;
    public bool active = false;
    private bool canGetTarget = true;
    private bool targetSent = false;
    private GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (canGetTarget)
        {
            if (other.gameObject.tag == "Enemy")
            {
                target = other.gameObject;
            }
            else if (other.gameObject.tag == "Player") {
                target = other.gameObject;
            }
        }
    }
}
