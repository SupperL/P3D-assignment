using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            StartCoroutine(DoorOpen());
        }
    }


    IEnumerator DoorOpen()
    {
        yield return transform.parent.DOLocalRotate(new Vector3(0, 0, 0), 3).WaitForCompletion();
        transform.parent.DOLocalRotate(new Vector3(0, 90, 0), 3);
    }

}
