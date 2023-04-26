using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight_deliter : MonoBehaviour
{
    public Right_Point right_Point;
    public Left_Point_enter left_Point_Enter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weight_y")
        {
            Debug.Log("weight");
            Destroy(other.gameObject);
        }
    }
}
