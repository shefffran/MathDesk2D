using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void SetPosition(Transform obj)
    {
        obj.position = Input.mousePosition;
    }
}
