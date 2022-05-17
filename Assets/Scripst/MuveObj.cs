using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuveObj : MonoBehaviour
{
    private Transform position;
    public Vector3 directionMove = new Vector3(0, 0, 0);
    public float x = 0;
    public float y = 0;
    public float startX = 0;
    public float startY = 0;
    //public Vector3 endPosition = new Vector3(0, 0, 0);
    private void Start()
    {
        position = this.transform;
        startY = position.localPosition.y;
        startX = position.localPosition.x;
    }
    public void MuveForvard()
    {
        StartCoroutine(MuveForvardCoroutine());
    }

    private IEnumerator MuveForvardCoroutine()
    {

        while (position.localPosition.x < x || position.localPosition.y < y)
        {
            position.localPosition += directionMove * Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(2);

        while (position.localPosition.x > startX || position.localPosition.y > startY)
        {
            position.localPosition -= directionMove * Time.deltaTime;
            yield return null;
        }
        yield return null;
    }

  
}
