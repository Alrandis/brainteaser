using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button_Function : MonoBehaviour
{
    [SerializeField] private UnityEvent OnButtonPresd;
    private void OnTriggerEnter(Collider other)
    {
        OnButtonPresd.Invoke();
        transform.localPosition += new Vector3(0, 0, 0.1f);
    }
    private void OnTriggerExit(Collider other)
    {
        
        transform.localPosition -= new Vector3(0, 0, 0.1f);
    }
}
