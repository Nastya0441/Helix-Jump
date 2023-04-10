using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraF : MonoBehaviour
{
    public Player Player;
    public Vector3 PlatformCamera;
    public float Speed;

    void Update()
    {
        if (Player.CurrentPlatform == null)
            return;
        Vector3 targetPosition = Player.CurrentPlatform.transform.position + PlatformCamera;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed*Time.deltaTime);
    }
}
