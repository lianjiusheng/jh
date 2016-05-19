using UnityEngine;
using System.Collections;


public class Charactor : MonoBehaviour
{

    public int max_hp;

    public int curr_hp;

    public int attk;

    public int def;


    /// <summary>
    /// 使用技能
    /// </summary>
    public void UseSkill(Charactor target)
    {

        Animator animator=gameObject.GetComponent<Animator>();

        animator.SetInteger("state", 1);

      
        GameObject skillPrefab = (GameObject)Resources.Load("Prefabs/sk002");
        // Instantiate the explosion where the rocket is with the random rotation.
        GameObject skillObject= (GameObject)Instantiate(skillPrefab, target.gameObject.transform.position, Quaternion.identity);
       

        GameObject battle = GameObject.Find("battle");

        skillObject.transform.SetParent(battle.transform);
        skillObject.transform.position = target.transform.position;

        Skill skill = skillObject.GetComponent<Skill>();
        skill.attacker = this;
        skill.targets.Add(target);

        skill.OnDisplay();
    }

    /// <summary>
    /// 插入
    /// </summary>
    /// <param name="charactor"></param>
    /// <param name="skillId"></param>
    public void OnHurt(Charactor attacker, int skillId)
    {

        Animator animator = gameObject.GetComponent<Animator>();
        animator.SetInteger("state", 2);

        GameObject hurtTipsPrefab = (GameObject)Resources.Load("Prefabs/HurtTips");
        GameObject hurtTipsObject = (GameObject)Instantiate(hurtTipsPrefab, gameObject.transform.position, Quaternion.identity);


        GameObject pannel = GameObject.Find("Panel");
        hurtTipsObject.transform.SetParent(pannel.transform);
        hurtTipsObject.transform.localScale = new Vector3(1, 1, 1); 
          GameObject battle = GameObject.Find("battle");
        battle.GetComponent<Battle>().nextCharactor();

    }


    public void ChangeState()
    {

        Animator animator = gameObject.GetComponent<Animator>();
        int state = animator.GetInteger("state");
        
        if (state == 1)
        {
            animator.SetInteger("state", 0);
        }
        else if(state==2)
        {
            if (curr_hp <= 0)
            {
                curr_hp = 0;
                Destroy(gameObject);
            }
            else
            {
                animator.SetInteger("state", 0);
            }

        }

    }

}
