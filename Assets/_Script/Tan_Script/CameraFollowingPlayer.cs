using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingPlayer : MonoBehaviour
{
    public GameObject player;

    [Range(-5f,5f)]
    public float x;

    [Range(-2f,2f)]
    public float y;

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + x, player.transform.position.y +y, -10f);

    }

}
