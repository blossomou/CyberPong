using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
     [SerializeField]private float speed;
     private Vector3 direction;
     private Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        this.direction = new Vector3(0.5f, 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Method 1
       // transform.position += direction * speed * Time.deltaTime;
    }

    void FixedUpdate() {
        this._rigidBody.MovePosition(this._rigidBody.position + direction * speed * Time.fixedDeltaTime);
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Wall")){
            direction.z = -direction.z;
        }

        if(other.CompareTag("Racket")){
            direction.x = -direction.x;
        }
    }
}
