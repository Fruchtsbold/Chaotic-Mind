using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {


    public GameObject player;
    public bool phase2;
    public float speed;
    public float triggerDistance;

    private Vector3 playerpos;
    private Vector3 mypos;

    void Start () {
        phase2 = false;
        mypos = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (phase2)
        {
            playerpos = player.transform.position;

            Vector3 direction = playerpos - mypos;
            Debug.Log(direction.magnitude);
            if(direction.magnitude < triggerDistance)
            {
                this.gameObject.transform.Translate(direction.normalized * speed);

            }
        }
	}
}
