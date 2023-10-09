using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoLaser : MonoBehaviour
{
    public float VelocLaser = 12.0f ;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * VelocLaser * Time.deltaTime);
       
        if ( transform.position.y > 30f ){
            Destroy(this.gameObject);
        }

    }
}