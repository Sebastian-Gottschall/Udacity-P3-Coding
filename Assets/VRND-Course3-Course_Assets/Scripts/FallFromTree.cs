using UnityEngine;
using System.Collections;

public class FallFromTree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    //void Update () {
    //    if (transform.position.y > 0.6f)
    //    {
    //        transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
    //    }
    //}

    void Update()
    {
        transform.position = new Vector3(0, 10 + Mathf.Sin(Time.time * 5.0f), 0);
    }
}
