using UnityEngine;
using System.Collections;

public class HurtTips : MonoBehaviour {

    //销毁时间
    public float FreeTime = 0.5F;
    // Use this for initialization
    void Start () {
        
        StartCoroutine("Free");
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.up * 1F * Time.deltaTime);
    }

    IEnumerator Free()
    {
        yield return new WaitForSeconds(FreeTime);
        Destroy(this.gameObject);
    }
}
