using UnityEditor;
using UnityEngine;

public class EditorExample : EditorWindow
{
    [MenuItem("Example/EditorWindow")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        EditorExample window = (EditorExample)GetWindow(typeof(EditorExample));
        window!.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Example", EditorStyles.boldLabel);
    }
}
