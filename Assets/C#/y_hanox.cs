using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class y_hanox : MonoBehaviour
{

    public GameObject[] gameObjects;

    public void tagWithWeight()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Weight_y");
        for(int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].gameObject.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        }
    }
}