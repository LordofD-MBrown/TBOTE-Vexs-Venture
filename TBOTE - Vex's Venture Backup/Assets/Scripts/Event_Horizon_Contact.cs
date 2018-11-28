using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Event_Horizon_Contact: MonoBehaviour {

    GameObject Black_Hole;
    //GameObject Object;

    //Target Marker
    //public Transform target;

    //Speed in Units per Second
    public float speed;
    float r_speed;
    //public Vector3 attraction = Vector3.zero;
    //private Vector3 offset;

    bool contact = false;
    Vector3 rotation_direction;
    Vector3 target;

	// Use this for initialization
	void Start ()
    {
        r_speed = .1f * Time.deltaTime;
        Black_Hole = GameObject.Find("Black_Hole");
	}
	

	// Update is called once per frame
	void Update ()
    {
		if(contact == true)
        {
            target = Black_Hole.transform.position - transform.position;
            //offset = transform.position - Black_Hole.transform.position;
            float attraction_rate = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Black_Hole.transform.position ,attraction_rate);
            rotation_direction = Vector3.RotateTowards(transform.forward, Black_Hole.transform.position, r_speed, 0.0f);
            transform.rotation = Quaternion.LookRotation(rotation_direction);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Event_Horizon")
        {
            contact = true;
        }
    }
}
