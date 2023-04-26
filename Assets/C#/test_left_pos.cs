using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_left_pos : MonoBehaviour
{
    public GameObject weight_pos;

    private void OnTriggerStay2D(Collider2D collision)
    {
        weight_pos = collision.gameObject;
    }
}
