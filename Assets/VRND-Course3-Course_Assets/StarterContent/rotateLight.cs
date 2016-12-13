using UnityEngine;
using System.Collections;

public class rotateLight : MonoBehaviour {

    public GameObject directionalLight;
    public Animator sunRotationAnimation;

    float startTime = 0f;
    bool isPressed = false;

	// Use this for initialization
	void Start () {
        GvrViewer.Instance.OnTrigger += ActivateRotation;
        sunRotationAnimation.StartPlayback();
	}
	
	// Update is called once per frame
	void Update () {

        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
        Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);
        if (isPressed == true)
        {
            sunRotationAnimation.StopPlayback();
            //directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, startTime / 10f);
            startTime += Time.deltaTime;
        }
        
        //directionalLight.transform.Rotate(0f, Time.deltaTime, 0f);
    }

    public void ActivateRotation()
    {
        isPressed = true;
        sunRotationAnimation.SetBool("ChangeColor", true);
    }
}
