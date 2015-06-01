using UnityEngine;
using System.Collections;

public class ContrrolShooter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("test shooter");
	}

    void Déplacement()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
            transform.position += new Vector3(0, -1f, 0);

        if (Input.GetKeyDown(KeyCode.D))
            transform.position += new Vector3(0, 0, 1f);

        if (Input.GetKeyDown(KeyCode.Q))
            transform.position += new Vector3(0, 0, -1f);

        if (Input.GetKeyDown(KeyCode.Z))
            transform.position += new Vector3(-1f, 0, 0);

        if (Input.GetKeyDown(KeyCode.S))
            transform.position += new Vector3(1f, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
            transform.position += new Vector3(0, 1f, 0);

    }
	
	// Update is called once per frame
	void Update () {

        Déplacement();
	}
}
