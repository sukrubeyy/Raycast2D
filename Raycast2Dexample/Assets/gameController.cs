using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    RaycastHit2D hit;

    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.Raycast(Vector2.zero, Input.mousePosition);
            if(hit!=null)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
