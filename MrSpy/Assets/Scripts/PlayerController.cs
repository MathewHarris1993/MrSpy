using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 30.0f;
    public float zRange = 30.0f;
    private GameObject focalPoint;
    public GameObject bulletPrefavb;
    public float fpSpeed = 30;


    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("Focal Point");

    }

    // Update is called once per frame
    void Update()
    {
        //set limits on x movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        
       
        //set limits on z movement
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
            {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //movement controls
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(focalPoint.transform.forward * verticalInput * Time.deltaTime * speed);

        /*horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);*/
        transform.Rotate(focalPoint.transform.up * horizontalInput * fpSpeed);

        //fire bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefavb, transform.position, bulletPrefavb.transform.rotation);

        }
    }
}

