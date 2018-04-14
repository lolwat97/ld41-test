using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Force : MonoBehaviour {

    public float ForceMult;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        float HorizontalForce = MoveHorizontal * ForceMult;
        float VerticalForce = MoveVertical * ForceMult;

        rb.AddForce(new Vector3(HorizontalForce, 0, VerticalForce));
    }
}
