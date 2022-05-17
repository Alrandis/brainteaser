using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Renderer rend;
    [SerializeField] private GameObject door;
    private int colliderCount = 0;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(colliderCount == 0)
        {
            door.SetActive(false);
            Debug.Log("Дверь открыта");
            rend.material.color = new Color(1, 0, 0);
            transform.localPosition += new Vector3(0, 0, 0.1f);
        }
        colliderCount++;
    }

    private void OnTriggerExit(Collider other)
    {
        colliderCount--;
        if(colliderCount == 0)
        {
            door.SetActive(true);
            Debug.Log("Дверь закрыта");
            rend.material.color = new Color(0, 1, 0);
            transform.localPosition -= new Vector3(0, 0, 0.1f);
        }
        
    }
}
