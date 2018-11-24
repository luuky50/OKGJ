using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public GameObject player;
    public int damage = 0;
    private Animator comp;
    private bool canAttack= false;
	// Use this for initialization
	void Start () {
        comp = player.GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            canAttack = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canAttack = false;
        }
        if (canAttack)
        {
            comp.SetTrigger("AttackH1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var _enemyHealth = other.GetComponent<Health>();
        if (_enemyHealth!=null)
        { _enemyHealth.health -= damage; }
        canAttack = false;
    }
}
