
using UnityEngine;

[ExecuteInEditMode]
public class AutoParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("(")){
            gameObject.name = gameObject.name.Remove(gameObject.name.Length - 4);

        }
        GameObject[] gameObjects = FindObjectsOfType<GameObject>();

        foreach(GameObject g in gameObjects){
            if (g.name == $"{gameObject.name}s"){
                transform.SetParent(g.transform);
                 return;
            }
        }

        GameObject newGameObject = new GameObject($"{gameObject.name}s");
        transform.SetParent(newGameObject.transform);
    }
}
