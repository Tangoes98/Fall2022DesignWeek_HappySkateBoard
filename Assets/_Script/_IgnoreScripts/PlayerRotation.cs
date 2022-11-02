using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField]
    GameObject[] rtPivot;

    [Range(10f, 30f)]
    public float deltaRt;
    float rt;

    [SerializeField]
    GameObject[] rtPvPos;

/*    [Header("To check player's boolean isGround")]
    [SerializeField]
    GameObject player;*/

    private void Awake()
    {
        rt = 0f;
    }

    private void Update()
    {
        /*        if (player.GetComponent<PlayerMovement>().isGround == true)
                {

                    if (Input.GetKey(KeyCode.Q))
                    {
                        rt += deltaRt * 0.5f * Time.deltaTime;
                        rtPivot[0].transform.Rotate(Vector3.forward, rt, Space.Self);
                    }
                    else if (Input.GetKey(KeyCode.E))
                    {
                        rt += deltaRt * 0.5f * Time.deltaTime;
                        rtPivot[1].transform.Rotate(Vector3.back, rt, Space.Self);
                    }
                    else
                    {
                        rt = 0;
                    }
                }*/
        

/*        rtPivot[0].transform.position = rtPvPos[0].transform.position;
          rtPivot[1].transform.position = rtPvPos[1].transform.position;
        */



        if (Input.GetKey(KeyCode.Q))
        {
            rt += deltaRt * 0.5f * Time.deltaTime;
            rtPivot[0].transform.Rotate(Vector3.forward, rt, Space.Self);
        }
        else if (Input.GetKey(KeyCode.E))
        {

            rt += deltaRt * 0.5f * Time.deltaTime;
            rtPivot[1].transform.Rotate(Vector3.back, rt, Space.Self);
        }
        else
        {
            rt = 0;
        }

    }


}
