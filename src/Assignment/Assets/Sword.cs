using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        //print("a");
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    public Vector3 startPos,startRot;
    Transform parent;
    Rigidbody rigidbody;


    void Start()
    {
        startPos = transform.localPosition;
        print(startPos);
        startRot = transform.localRotation.eulerAngles;
        parent = transform.parent;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null)
            rigidbody.velocity = Vector3.zero;
        if(Input.GetKeyDown(KeyCode.K) && Vector3.Distance(player.transform.position,transform.position)<=1)
        {
            rigidbody.useGravity = false;
            rigidbody.velocity = Vector3.zero;
            transform.SetParent(parent, true);

            transform.localPosition = startPos;
            transform.localRotation = Quaternion.Euler(startRot);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            rigidbody.useGravity = true;

            rigidbody.AddForce(player.transform.forward*10);
            transform.SetParent(null);
        }
    }
}
