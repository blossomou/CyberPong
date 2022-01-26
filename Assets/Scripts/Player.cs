using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private KeyCode up;
    [SerializeField]private KeyCode down;

    private Rigidbody _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if(pressedUp){
            _rigidBody.velocity = Vector3.forward * speed; //forward means z axis
        }

        if(pressedDown){
            _rigidBody.velocity = Vector3.back * speed;
        }

        if(!pressedUp && !pressedDown){
            _rigidBody.velocity = Vector3.zero;
        }
    }
}
