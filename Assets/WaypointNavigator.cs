using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    [SerializeField] CharacterNavigationController cnc;
    public Waypoint currentWaypoint;
    private void Awake()
    {
        cnc = GetComponent<CharacterNavigationController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
