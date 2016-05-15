using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Skill : MonoBehaviour {

    public int SkillId;
    public Charactor attacker;
    public List<Charactor> targets;


	// Use this for initialization
	void Start () {
        targets = new List<Charactor>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnDisplay()
    {
        Animator animator= gameObject.GetComponent<Animator>();
        animator.SetBool("play", true);
    }

    public void Stop() {

        Animator animator = gameObject.GetComponent<Animator>();
        animator.SetBool("play", false);

        foreach (Charactor target in targets)
        {
            target.OnHurt(attacker, SkillId);
        }
            
         Destroy(gameObject);
    }
}
