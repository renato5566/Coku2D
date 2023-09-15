using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundo : MonoBehaviour

{

    private float length;

    private float startpos;

 

    private Transform cam;

 

    public float ParallaxEffect;

    void Start()

    {

       startpos = transform.position.x;

       length = GetComponent<SpriteRenderer>().bounds.size.x;

       cam = Camera.main.transform;

    }

 

 

    void Update()

    {

        float repos = cam.transform.position.x * (1 - ParallaxEffect);

        float distance = cam.transform.position.x * ParallaxEffect;

 

        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

        if(repos > startpos + length)

        {

            startpos += length;

        }

        else if (repos < startpos - length)

        {

            startpos -= length;

        }

 

    }

}
