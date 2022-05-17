using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    [SerializeField] private int acceleration;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("ZDirection"));
        m_Rigidbody.AddForce(direction * acceleration);
        if (Input.GetButton("Jump"))
        {
            var bigArea = Physics.OverlapSphere(transform.position, 5f);
            var smallArea = Physics.OverlapSphere(transform.position, 0.6f);
            foreach(var obj in bigArea)
            {
                if (System.Array.IndexOf(smallArea, obj) == -1 && obj.tag == "Box")
                {
                    obj.attachedRigidbody.AddForce((transform.position - obj.transform.position) * 1);
                }
            }
        }
    }
}
