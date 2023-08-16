using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ConeMeshController))]
public class ConeMeshEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ConeMeshController coneMeshController = (ConeMeshController)target;

        GUILayout.Space(10);

        if (GUILayout.Button("Update Cone"))
        {
            coneMeshController.UpdateConeVertices();
        }
    }
}
