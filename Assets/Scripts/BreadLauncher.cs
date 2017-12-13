using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadLauncher : MonoBehaviour {
    public Rigidbody bread;
    private Camera mainCam;

    public float verticalForce = 10;
    public float horizontalForce = 10;

    void Start () {
        mainCam = Camera.main;

    }
	
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            LaunchBread();
        }
	}

    private void LaunchBread() {
        var breadInst = Instantiate(bread);
        breadInst.transform.position = transform.position;
        breadInst.gameObject.SetActive(true);
        breadInst.AddForce(Vector3.up * verticalForce - mainCam.transform.right * horizontalForce, ForceMode.Impulse);
    }
}
