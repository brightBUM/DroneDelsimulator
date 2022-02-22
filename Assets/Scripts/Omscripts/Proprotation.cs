using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proprotation : MonoBehaviour
{
    [SerializeField] float rotationspeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,180* rotationspeed * Time.deltaTime, 0));
    }
}
