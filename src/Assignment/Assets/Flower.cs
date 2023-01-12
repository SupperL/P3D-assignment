using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    public GameObject flower,player,flashFlower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(flower.transform.position,player.transform.position)<=0.5)
        {
            GetComponent<MeshRenderer>().enabled = true;
            flower.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.L)&& GetComponent<MeshRenderer>().enabled ==true)
        {
            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            flower.SetActive(false);
            Instantiate(flashFlower,player.transform.position+player.transform.forward,Quaternion.identity);
        }
    }
}
