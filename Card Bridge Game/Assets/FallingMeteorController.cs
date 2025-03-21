using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingMeteorController : MonoBehaviour
{
    float wait = 0.5f;
    public GameObject fallingMeteor;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fall", wait, wait);
    }

    void Fall ()
    {
        Instantiate(fallingMeteor, new Vector3(Random.Range(-10,10), 10, 0), Quaternion.identity);
    }
}
