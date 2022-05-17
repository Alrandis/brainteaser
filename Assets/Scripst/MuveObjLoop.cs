using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuveObjLoop : MonoBehaviour
{
    private Transform position;
    [SerializeField] private Vector3 directionMove = new Vector3(0, 0, 0);
    [SerializeField] private float x = 0;
    [SerializeField] private float z = 0;
    private float startX = 0;
    private float startZ = 0;
    //public Vector3 endPosition = new Vector3(0, 0, 0);
    private void Start()
    {
        position = this.transform;
        startZ = position.localPosition.z;
        startX = position.localPosition.x;
    }
    public void MuveForvard()
    {
        StartCoroutine(MuveForvardCoroutine());
    }

    private IEnumerator MuveForvardCoroutine()
    {

        while (position.localPosition.x < x || position.localPosition.z < z)
        {
            position.localPosition += directionMove * Time.deltaTime;
            yield return null;
        }
        yield return null;

        while (position.localPosition.x > startX || position.localPosition.z > startZ)
        {
            position.localPosition -= directionMove * Time.deltaTime;
            yield return null;
        }
        yield return null;

        MuveForvard();
    }


}
