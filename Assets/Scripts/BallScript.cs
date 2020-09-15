using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BallScript : MonoBehaviour
{
    public Renderer bRenderer;
    public WallScript wall;
    public WallScript wall2;

    public Transform Platform1;
    public Transform Platform2;

    public float y1;
    public float y2;
    

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        y1 = Platform1.position.y;
        y2 = Platform2.position.y;

        MoveLeft();
    }

    public void MoveLeft()
    {
        wall.ball();
        transform.DOMoveY(y2, speed).OnComplete(MoveRight);
       
        bRenderer.material.DOColor(Color.cyan, 3f);
    }
    public void MoveRight()
    {
        wall2.ball();
        transform.DOMoveY(y1, speed).OnComplete(MoveLeft);        
        bRenderer.material.DOColor(Color.red, 3f);
    }



    // Update is called once per frame
    void Update()
    {
       
        y1 = Platform1.position.y;
        y2 = Platform2.position.y;

    }
}
