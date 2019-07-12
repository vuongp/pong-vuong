using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1ControlScript : MonoBehaviour
{

    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start() {
      rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
      rigidbody.velocity = new Vector3 (0,Input.GetAxis("Vertical") * 3, 0f);
    }
}
