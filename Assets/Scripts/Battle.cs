using UnityEngine;
using System.Collections;

public class Battle : MonoBehaviour {


    public GameObject[] attackers;

    public GameObject[] defencers;

    public GameObject currentPlayer;
    public GameObject currentSkill;


    void Awake()
    {
        attackers = new GameObject[1];
        defencers = new GameObject[1];

        initPlayers();
        nextCharactor();
    }
	// Use this for initialization
	void Start () {
    }
	
    private void initPlayers()
    {
        attackers[0] = loadCharatorPrefab(new Vector3(0, -4.3f, 0));
        defencers[0] = loadCharatorPrefab(new Vector3(0, 1.8f, 0));
    }

    private GameObject loadCharatorPrefab(Vector3 v3)
    {

        GameObject characterPrefab = (GameObject)Resources.Load("Prefabs/Character");

        Vector3 p = gameObject.transform.position + v3;

        // Instantiate the explosion where the rocket is with the random rotation.
        GameObject charactor= (GameObject)Instantiate(characterPrefab, p, Quaternion.identity);

        charactor.transform.parent = gameObject.transform;
       
        return charactor;
    }

	// Update is called once per frame
	void Update () {
	

	}

    public void nextCharactor()
    {
        if (currentPlayer == null)
        {
            currentPlayer = attackers[0];
            return;
        }

        if (currentPlayer == attackers[0])
        {
            currentPlayer = defencers[0];
        }
        else
        {
            currentPlayer = attackers[0];
        }
    }


    public void UseSkill()
    {
        GameObject target = SelectTarget();

        currentPlayer.GetComponent<Charactor>().UseSkill(target.GetComponent<Charactor>());
    }


    public GameObject SelectTarget()
    {
        if (currentPlayer == attackers[0])
        {
            return defencers[0];
        }
        return attackers[0];
    }
}
