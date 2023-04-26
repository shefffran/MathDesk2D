using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Left_Point_enter : MonoBehaviour
{
    public GameObject[] weight_prefabs;
    public GameObject[] weight_prefabs_start;
    public GameObject left_point;
    public test_right_point test_Right_Point;
    public test_right_bottom test_Right_Bottom;
    public GameObject board;
    public int x = 0;
    public GameObject gameobjtest;
    public int weight_index = 0;
    public int tempt_index = 0;
    public string weight_indexx;
    public DistanceJoint2D distanceJoint;

    public GameObject[] start_pos_prefab;
    public Vector3[] start_pos_prefab_vector;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weight")
        {
            if (x < 3)
            {

                Debug.Log("weight");
                weight_indexx = Regex.Replace(other.gameObject.name, "[^0-9]", "");
                weight_index = int.Parse(weight_indexx) - 1;

                if (x == 0)
                {
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedAnchor = new Vector2(-5.8f,0f);
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedBody = board.GetComponent<Rigidbody2D>();
                    Instantiate(weight_prefabs[weight_index], new Vector3(-6f, 0.5f, 0f), Quaternion.identity);

                }
                if (x == 1)
                {
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedAnchor = new Vector2(0f, 0f);
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedBody = test_Right_Point.weight_pos.gameObject.GetComponent<Rigidbody2D>();
                    Instantiate(weight_prefabs[weight_index], new Vector3(-6f, -1f, 0f), Quaternion.identity);
                }
                if (x == 2)
                {
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedAnchor = new Vector2(0f, 0f);
                    weight_prefabs[weight_index].GetComponent<DistanceJoint2D>().connectedBody = test_Right_Bottom.weight_pos_bottom.gameObject.GetComponent<Rigidbody2D>();
                    Instantiate(weight_prefabs[weight_index], new Vector3(-6f, -2.5f, 0f), Quaternion.identity);
                }
                x++;


            }
        }
    }

    public void Text()
    {
        Instantiate(weight_prefabs[1], new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
