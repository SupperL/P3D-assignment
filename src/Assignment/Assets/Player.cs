using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            GetComponent<Animator>().Play("MeleeAttack_OneHanded");
            GetComponent<AudioSource>().Play();
        }

    }
}
