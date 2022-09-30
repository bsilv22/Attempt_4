using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rd;
    public GameObject explosion;
    public TMPro.TextMeshProUGUI text;
    private Vector2 vector2;
    public float speed = 1000;
    public float totalHealth = 0f;
    
    //overwrties monobehavior of inputsystem
    void Start()
    {
        //is a object of ridgebody
        rd = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue input)
    {
        vector2 = input.Get<Vector2>() * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //dont want to move on y axis - hence 0
        rd.AddForce(vector2.x, 0, vector2.y);
        //Debug.Log("Vector2X is " + vector2.x);
    }

    private void OnTriggerEnter(Collider other)
    {
        explosion.transform.position =
            other.gameObject.transform.position;
        Instantiate(explosion);
        totalHealth += other.gameObject.GetComponent<PickUp>().healthPickUp;
        text.text = "Health " + totalHealth;
        other.gameObject.SetActive(false);
       
    }
}
