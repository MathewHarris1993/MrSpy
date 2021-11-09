using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private GameObject focalPoint;
    public float bulletSpeed = 40f;
    private int zrange = 30;
    private int xrange = 30;
    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        //once bullet is fired, how it moves
        transform.Translate(focalPoint.transform.forward * Time.deltaTime * bulletSpeed);

        //bullet destroyed when off screen
        if(transform.position.z > zrange)
        {
            Destroy(gameObject);

        }
        if (transform.position.z < -zrange)
        {
            Destroy(gameObject);

        }
        if (transform.position.x > xrange)
        {
            Destroy(gameObject);

        }
        if (transform.position.x < -xrange)
        {
            Destroy(gameObject);

        }
    }
}
