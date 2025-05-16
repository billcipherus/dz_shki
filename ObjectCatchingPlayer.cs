using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectCatchingPlayer : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private bool triggerActive = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    GameObject popup;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TakingObject")
        {
            popup.SetActive(true);
            triggerActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TakingObject")
        {
            popup.SetActive(false);
            triggerActive = false;
        }
    }

    public void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            SomeAction();
        }

    }

    public void SomeAction()
    {

    }
}
