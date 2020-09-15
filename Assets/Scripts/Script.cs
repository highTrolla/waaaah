using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Script : MonoBehaviour
{

    public Renderer m_Renderer;


    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(3f, 1.5f).OnComplete(MoveDown);
        transform.DOPunchScale(Vector3.one * 2, 1.5f).OnComplete(FadeOff);
        m_Renderer.material.DOColor(Color.cyan, 10f);
        m_Renderer.material.DOFade(0f, 1.5f);
    }

    private void MoveDown()
    {
        transform.DOMoveY(0f, 0.75f);
    }

    private void FadeOff()
    {
        m_Renderer.material.DOFade(1f, 1.5f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
