using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> pedestrianPrefabs;
    [SerializeField] int no_of_pedestrains;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());   
    }

    IEnumerator spawn()
    {
        int count = 0;
        while(count<no_of_pedestrains)
        {
            GameObject objref = Instantiate(pedestrianPrefabs[Random.Range(0,pedestrianPrefabs.Count)]);
            Transform child =  transform.GetChild(Random.Range(0, transform.childCount - 1));
            objref.GetComponent<WaypointNavigator>().currentWaypoint = child.GetComponent<Waypoint>() ;
            objref.transform.position = child.position+new Vector3(0,0,1);
            SetRandomSpeed(objref);
            yield return new WaitForEndOfFrame();
            count++;
        }
    }

    void SetRandomSpeed(GameObject npc)
    {
        npc.GetComponent<CharacterNavigationController>().movementSpeed = Random.Range(1, 4);
    }
}
