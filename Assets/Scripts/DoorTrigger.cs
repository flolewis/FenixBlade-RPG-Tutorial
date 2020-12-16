using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject indicator;
    public Animator animator;
    bool isOpen;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            indicator.gameObject.SetActive(true);
            Debug.Log("Player Entered Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            indicator.gameObject.SetActive(false);
            Debug.Log("Player Exited Range");
        }
    }

    private void DoorAnimTrigger(){
        isOpen = !isOpen;
        if(indicator.activeInHierarchy && Input.GetKey(KeyCode.F)){
            animator.SetBool("Open",isOpen);
        }
    }
    private void Update() {
        DoorAnimTrigger();
    }
}
