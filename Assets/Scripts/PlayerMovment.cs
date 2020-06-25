using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public Rigidbody rb;

    public float ForwForce = 2000f;
    public float SideForce = 100f;


    // Update is called once per frame
    void FixedUpdate(){

        rb.AddForce(0, 0, ForwForce * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
