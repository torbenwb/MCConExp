using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneViewCamera))]
public class SceneViewCameraEditor : Editor{
    void OnSceneGUI(){
        SceneViewCamera svc = (SceneViewCamera)target;
        svc.transform.position = SceneView.lastActiveSceneView.camera.transform.position;
        svc.transform.rotation = SceneView.lastActiveSceneView.camera.transform.rotation;
    }
}

public class SceneViewCamera : MonoBehaviour
{
    
}
