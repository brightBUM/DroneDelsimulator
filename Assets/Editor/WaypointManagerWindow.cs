using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WaypointManagerWindow : EditorWindow
{
    [MenuItem("Tools/Waypoint Editor")]
    public static void Open()
    {
        GetWindow<WaypointManagerWindow>();
    }
    public Transform waypointRoot;
    private void OnGUI()
    {
        SerializedObject obj = new SerializedObject(this);
        EditorGUILayout.PropertyField(obj.FindProperty("waypointRoot"));
        if(waypointRoot == null)
        {
            EditorGUILayout.HelpBox("please assign a Root Transform", MessageType.Warning);
        }
        else
        {
            EditorGUILayout.BeginVertical("box");
            DrawButtons();
            EditorGUILayout.EndVertical();

        }
        obj.ApplyModifiedProperties();
    }
    void DrawButtons()
    {
        if(GUILayout.Button("Create Waypoint"))
        {
            CreateWaypoint();
        }
    }
    void CreateWaypoint()
    {
        GameObject waypointObject = new GameObject("Waypoint" + waypointRoot.childCount, typeof(Waypoint));
        waypointObject.transform.SetParent(waypointRoot,false);
        Waypoint waypoint = waypointObject.GetComponent<Waypoint>();
        if(waypointRoot.childCount>1)
        {
            waypoint.previousWayPoint = waypointRoot.GetChild(waypointRoot.childCount - 2).GetComponent<Waypoint>();
            waypoint.previousWayPoint.nextWayPoint = waypoint;
            //Place the waypoint at the last position
            waypoint.transform.position = waypoint.previousWayPoint.transform.position;
            waypoint.transform.forward = waypoint.previousWayPoint.transform.forward;
        }
        Selection.activeGameObject = waypoint.gameObject;
    }
}
