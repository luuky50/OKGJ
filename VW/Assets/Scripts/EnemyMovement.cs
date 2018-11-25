using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public bool active=false;
    public GameObject target;
    public int speed=0;
    public int minTimer, maxTimer;
    private float timer;
    private int walkDirection;
    private bool gotDirection = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            if (!gotDirection)
            {
                walkDirection = Random.Range(1, 4);
                gotDirection = true;
                timer = Random.Range(minTimer, maxTimer);

            } else if (gotDirection)
            {
                Move();
                CountDown();
            }
            




        }
        else return;
	}

    void CountDown()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            Debug.Log("Timer Done");
            gotDirection = false;
        }
    }

    private void Move()
    {
        Vector3 direction = Vector3.zero;

        if (walkDirection == 1)
        {
            direction.z = 1;
        }
        else if (walkDirection == 2)
        {
            direction.z = -1;
        }


        if (walkDirection == 3)
        {
            direction.x = -1;
        }
        else if (walkDirection == 4)
        {
            direction.x = 1;
        }

        transform.LookAt(this.transform.position + direction);
        if (direction != Vector3.zero)
        {
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
        }
    }
}
