using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_loop : MonoBehaviour
{
    public Vector3 pos1 = new Vector3(1, 1, 0);
    public Vector3 pos2 = new Vector3(-1, -1, 0);
    public float speed = 5;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
