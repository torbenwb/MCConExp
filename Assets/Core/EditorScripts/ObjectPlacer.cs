using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectPlacer))]
public class ObjectPlacerEditor : Editor{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ObjectPlacer op = (ObjectPlacer)target;

        string name = op.gameObject.name;
        name = name.TrimEnd('s');
        if (GUILayout.Button($"New {name}")) op.NewObject();
    }

    void OnSceneGUI(){
        Tools.current = Tool.None;
        ObjectPlacer p = (ObjectPlacer)target;
        for(int i = 0; i < p.transform.childCount; i++){
            p.transform.GetChild(i).position = Handles.PositionHandle(p.transform.GetChild(i).position, Quaternion.identity);
        }
    }
}

public class ObjectPlacer : MonoBehaviour
{
    public GameObject objectType;

    public void NewObject(){
        if (objectType) {
            
            GameObject newObject = Instantiate(objectType, Vector3.zero, Quaternion.identity);
            newObject.transform.parent = transform;
        }
    }
    
}
