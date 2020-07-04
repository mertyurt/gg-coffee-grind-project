using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowderBox : MonoBehaviour
{
    Animator animatorP;
    // Start is called before the first frame update
    void Start()
    {
        animatorP = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() => Shake();

    void Shake()
    {
        animatorP.SetTrigger("isTapped");
    }
}
