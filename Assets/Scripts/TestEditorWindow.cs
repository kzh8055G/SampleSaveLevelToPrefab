using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestEditorWindow : EditorWindow
{

    private string inputString = "XXXXXX";

    [MenuItem("Window/Test")]
    private static void Init()
    {
        TestEditorWindow window = EditorWindow.GetWindow<TestEditorWindow>();
        window.Show();
        
    }
    
    void OnGUI()
    {
        GUILayout.Label("Base Setting", EditorStyles.boldLabel);
        inputString = EditorGUILayout.TextField("Text Field", inputString);
        
        



    }


    // // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
