using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_loop : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 15), speed * Time.deltaTime);
    }
}
