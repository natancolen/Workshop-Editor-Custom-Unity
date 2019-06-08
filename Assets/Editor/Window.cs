using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Window : EditorWindow
{
    static Color color = Color.blue;
    static GameObject prefab;

    [MenuItem("Custom/My Window")]
    static void Init()
    {
        Window window = (Window)EditorWindow.GetWindow(typeof(Window));
        window.Show();
    }

    public void OnGUI()
    {
        color = EditorGUILayout.ColorField("Cor", color);

        prefab = (GameObject) EditorGUILayout.ObjectField(prefab, typeof(GameObject), false);
        if (GUILayout.Button("Criar"))
        {
            this.Instancia();
        }
    }

    public void Instancia()
    {
        Instantiate(prefab);
        PrefabUtility.InstantiatePrefab(prefab);
    }
}
