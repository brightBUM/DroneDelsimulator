using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNavigationController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float rotationSpeed = 120f;
    [SerializeField] float stopDistance = 2.5f;
    [SerializeField] Vector3 destination;
    [SerializeField] public Transform nextDestination;
    [SerializeField] bool reachedDestination;

    // Start is called before the first frame update
    void Start()
    {
        destination = nextDestination.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position!=destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;
            float destinationDistance = destinationDirection.magnitude;
            if (destinationDistance >= stopDistance)
            {
                reachedDestination = false;
                Quaternion targetrotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetrotation, rotationSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                destination = nextDestination.position;
            }
        }
    }

    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}
