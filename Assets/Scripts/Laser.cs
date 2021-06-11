using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour

{
    [SerializeField]
    private float _laserspeed = 8.0f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _laserspeed);

        if (transform.position.y >= 8.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
