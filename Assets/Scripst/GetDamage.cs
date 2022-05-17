using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDamage : MonoBehaviour
{
    [SerializeField] private List<GameObject> dangerousObject;
    [SerializeField] private int Helth;
    //[SerializeField] private GameObject obj;
    private void OnTriggerEnter(Collider dangerousObject)
    {
        Helth -= 1;
        if (Helth == 0)
        {
            //Object.Destroy(obj);
            Destroy(gameObject);
        }
    }

}
