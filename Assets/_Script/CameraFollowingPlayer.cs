using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingPlayer : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 5f, player.transform.position.y - 1f, -10f);

    }

}
