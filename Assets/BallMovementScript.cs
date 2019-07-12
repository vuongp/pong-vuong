using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    private Vector3 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody2D>();

      lastVelocity = new Vector3 (-5,1 , 0f);
      rigidbody.velocity = lastVelocity;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
      if (col.gameObject.tag == "Wall") {
        lastVelocity = new Vector3 (lastVelocity.x, -lastVelocity.y, 0f);
        rigidbody.velocity = lastVelocity;
      } else {
        lastVelocity = new Vector3 (-lastVelocity.x, lastVelocity.y, 0f);
        rigidbody.velocity = lastVelocity;
      }
    }

}
