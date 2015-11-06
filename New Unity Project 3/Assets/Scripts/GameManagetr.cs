using UnityEngine;
using System.Collections;

public class GameManagetr : MonoBehaviour {

    public bool phase1;
    public bool phase2;
    public bool phase3;


    void Start()
    {
        phase1 = true;
        phase2 = false;
        phase3 = false;
    }
	
	void Update () {

        if (phase1)
        { 
            if(this.gameObject.transform.position.y < -3)
            {
                Application.LoadLevel("a");
            }
        }
        else if (phase2)
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Platform");
            for (int i=0; i < objs.Length; i++ )
            {
                objs[i].GetComponent<Platform>().phase2 = true;
            }
        }

	
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Platform" && phase2)
        {
            Application.LoadLevel("a");
        }

        if(collision.collider.tag.Equals("ChangeTrigger"))
        {
            Destroy(collision.collider.gameObject);
            phase1 = false;
            phase2 = true;
        }
    }

}
