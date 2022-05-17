using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerText : MonoBehaviour
{
    [SerializeField] private string mesage;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(mesage);
    }
}
