using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControl : MonoBehaviour
{
    [SerializeField] float headspeed;
    [SerializeField] float bodyspeed;
    [SerializeField] float turnspeed;
    [SerializeField] List<Transform> bodyparts;
    [SerializeField] GameObject bodyprefab;
    [SerializeField] List<Vector3> positionhistory;
    [SerializeField] int gap = 10;
    // Start is called before the first frame update
    void Start()
    {
        growsnake();
        growsnake();
        growsnake();
        growsnake();
        growsnake();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * headspeed * Time.deltaTime;
        float turndir = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnspeed * turndir*Time.deltaTime);
       
    }
    public void growsnake()
    {
        var temp = Instantiate(bodyprefab);
        bodyparts.Add(temp.transform);
    }
    private void FixedUpdate()
    {
        positionhistory.Insert(0, transform.position);
        int index = 0;
        foreach (Transform body in bodyparts)
        {
            Vector3 point = positionhistory[Mathf.Min(index * gap, positionhistory.Count - 1)];
            Vector3 direction = point - body.position;

            body.position += bodyspeed * direction * Time.deltaTime;
            body.LookAt(point);
            index++;
        }
    }
}
