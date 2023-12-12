using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCards : MonoBehaviour
{
    Vector3 target;
    void Start()
    {
        target = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                transform.position = target;
            }
        }
    }
}