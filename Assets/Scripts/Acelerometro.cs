using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 tilt;
    private bool isFlat = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputAccel = Input.acceleration;

        if(isFlat )
        {
            inputAccel = Quaternion.Euler(90,0,0) * inputAccel;
        }

        tilt.x = inputAccel.x;
        tilt.y = inputAccel.y;

        rb.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up,tilt,Color.cyan);
    }
}
