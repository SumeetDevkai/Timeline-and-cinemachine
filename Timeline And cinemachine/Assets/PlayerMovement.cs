using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float speed = 1;
    public Rigidbody rb;
    //public GameObject m;
     Animator anim;
    public GameObject pos;
   
    float e;
    bool jump;

	void Start ()
    {
      
        anim = gameObject.GetComponent<Animator>();
    }
    
	void Update ()
    {
        if (speed == 1)
        {
            this.transform.Translate( new Vector3(0, 0, speed)*1*Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //anim.Play("mixamo.com");
           anim.SetTrigger("Climb");
            speed = 0;
            
        }
    }
    public void moveyabody()
    {
        rb.transform.position = new Vector3(pos.transform.position.x, pos.transform.position.y, pos.transform.position.z);
        speed = 1;
    }
}
