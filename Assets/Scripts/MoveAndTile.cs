using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndTile : MonoBehaviour {

    public float Delta;
    public float AngularSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float TimeElapsed = Time.timeSinceLevelLoad;
        Vector3 NewPosition = new Vector3(Mathf.Sin(AngularSpeed * TimeElapsed) * Delta, transform.position.y, Mathf.Cos(AngularSpeed * TimeElapsed) * Delta);
        transform.position = NewPosition;
	}
}
