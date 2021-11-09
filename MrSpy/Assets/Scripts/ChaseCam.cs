using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCam : MonoBehaviour

{
    public float rotationSpeed = 50;

    public GameObject Player;
    private Vector3 offset = new Vector3(0, 10, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }

    //follow player
    void LateUpdate()
    {
        //move cam with player
        transform.position = Player.transform.position + offset;

    }
}
