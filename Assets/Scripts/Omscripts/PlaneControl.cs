using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    [SerializeField] float Planeforwardspeed;
    [SerializeField] float turnspeed;
    float yaw;
    float pitch;
    float roll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Planeforwardspeed * Time.deltaTime;
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        yaw += horizontalinput * turnspeed * Time.deltaTime;
        pitch = Mathf.Lerp(0, 20,Mathf.Abs(verticalinput)) *Mathf.Sign(verticalinput);
        roll = Mathf.Lerp(0, 30, Mathf.Abs(horizontalinput)) * -Mathf.Sign(horizontalinput);
        transform.localRotation = Quaternion.Euler(Vector3.up * yaw + Vector3.right*pitch+Vector3.forward*roll);
        //transform.Rotate(Vector3.up * turnspeed * turndir * Time.deltaTime);
    }
}
