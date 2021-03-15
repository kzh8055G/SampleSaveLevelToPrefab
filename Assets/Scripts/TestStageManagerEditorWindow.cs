using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TestStageManagerEditorWindow : EditorWindow
{
    [MenuItem("Window/EduApp/ManageStage")]
    private static void Init()
    {
        var window = EditorWindow.GetWindow<TestStageManagerEditorWindow>();
        window.Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Save Stage To Prefab"))
        {
            _SaveStageToPrefab();
        }
    }

    private void _SaveStageToPrefab()
    {
        GameObject stageRootObject = new GameObject("Root");

        var rootObjects = new HashSet<GameObject>();
        // * 현재 가장 root gameobject 들만 싹 모은다
        var objectArray= FindObjectsOfType<GameObject>();
        //GameObject[] objectArray = Selection.gameObjects;
        foreach (GameObject go in objectArray)
        {
            var rObject = _GetRootObject(go);
            if (!rootObjects.Contains(rObject))
            {
                rootObjects.Add(rObject);
                rObject.transform.SetParent(stageRootObject.transform);
            }
        }
        _SaveToPrefab(stageRootObject);
    }

    private void _SaveToPrefab(GameObject _go)
    {
        string localPath = "Assets/" + _go.name + ".Prefab";
        localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);
        PrefabUtility.SaveAsPrefabAssetAndConnect(_go, localPath, InteractionMode.UserAction);   
    }

    private void _LoadStageFromPrefab()
    {
        //PrefabUtility.Inst
    }
    private GameObject _GetRootObject(GameObject _gameObject)
    {
        if (_gameObject != null)
        {
            if (_gameObject.transform.parent != null)
            {
                return _GetRootObject(_gameObject.transform.parent.gameObject);
            }
        }
        return _gameObject;
    }


    // Start is called before the first frame update
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
