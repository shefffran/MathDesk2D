using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_left_bottom : MonoBehaviour
{
    public GameObject weight_pos_bottom;
     
    private void OnTriggerStay2D(Collider2D collision)
    {
        weight_pos_bottom = collision.gameObject;
    }
}
