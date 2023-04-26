using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskComplite : MonoBehaviour
{
    public GameObject deskCube;
    private Rigidbody2D deskCubeRb;
    public Buttons StartedScript;
    public GameObject Completee;
    public bool complete = false;
    private bool completFalse = false;
    public float maxRotate;
    private bool oneTime;
    private bool oneTime2;
    [SerializeField] private bool zFreez;


    private void Start()
    {
        oneTime = true;
        oneTime2 = true;
        zFreez = true;
        deskCubeRb = deskCube.GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        deskCubeRb.freezeRotation = zFreez;
        if (StartedScript.gameIsStarted)
        {
            zFreez = false;
            deskCubeRb.position = new Vector2(deskCube.transform.position.x, (float)(deskCube.transform.position.y + 0.001));
            StartCoroutine(ExecuteAfterTime(3f));
            float elapsedTime = 3f - Time.deltaTime;
            Debug.Log("Elapsed time: " + elapsedTime);
        }

        if (complete)
        {
            if (oneTime) {
                StartedScript._CompleteBtn();
                oneTime = false;
            }
        }


    }

    IEnumerator ExecuteAfterTime(float timeInSec)
    {

        yield return new WaitForSeconds(timeInSec);

        if (deskCube.transform.eulerAngles.z < maxRotate || deskCube.transform.eulerAngles.z > 360 - maxRotate)
        {
            if (!completFalse)
            {
                Debug.Log("on corutine");
                complete = true;
                completFalse = true;
            }

        }
        else
        {
            if (oneTime2)
            {
                StartedScript._WrongBtn();
                Completee.SetActive(false);
                oneTime2 = false;
            }
        }
    }
}
