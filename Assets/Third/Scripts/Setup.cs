//#if UNITY_EDITOR

//using UnityEditor;
//using UnityEditor.SceneManagement;
//using System.Collections.Generic;

//[InitializeOnLoad]
//class Setup
//{
//    const string demoScenePath = "Assets/Third/Scenes/demo.unity";

//    static Setup()
//    {
//        if (EditorApplication.isPlaying)
//        {
//            return;
//        }

//        List<EditorBuildSettingsScene> editorBuildSettingsScenes = new List<EditorBuildSettingsScene>();

//        if (EditorBuildSettings.scenes.Length > 0 && !string.Equals(EditorBuildSettings.scenes[0].path, demoScenePath))
//        {
//            editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(demoScenePath, true));
//        }

//        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
//        {
//            editorBuildSettingsScenes.Add(scene);
//        }

//        EditorBuildSettings.scenes = editorBuildSettingsScenes.ToArray();

//        OpenScene();
//    }

//    static void OpenScene()
//    {
//        if (EditorApplication.isPlaying)
//        {
//            return;
//        }

//        EditorApplication.delayCall += OpenSceneDelay;
//    }

//    static void OpenSceneDelay()
//    {
//        if (EditorApplication.isPlaying)
//        {
//            return;
//        }

//        EditorApplication.delayCall -= OpenSceneDelay;
//        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[0].path);
//    }
//}

//#endif