using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallScript : MonoBehaviour
{
    public float goHere;
    public Transform thisObject;
    public float dirSwap;

    // Start is called before the first frame update
    void Start()
    {
        goHere = thisObject.position.y;
    }

    public void ball()
    {
        transform.DOMoveY(goHere, 1f);
        goHere += dirSwap;
        transform.DOPunchScale(Vector3.one * 1.25f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
