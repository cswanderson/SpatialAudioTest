using UnityEditor;
using UnityEngine;

namespace UnityLibrary
{
    [CustomEditor(typeof(AudioManager))]
    public class AudioManagerCustomEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            AudioManager manager = (AudioManager)target;
            // idk how to generate the buttons procedurally, will fix later maybe
            if(GUILayout.Button("Play All"))
            {
                manager.TriggerAllSources();
            }
            EditorGUILayout.Space();
            if (GUILayout.Button("Play 1"))
            {
                manager.TriggerSource(1);
            }
            if (GUILayout.Button("Play 2"))
            {
                manager.TriggerSource(2);
            }
            if (GUILayout.Button("Play 3"))
            {
                manager.TriggerSource(3);
            }
            if (GUILayout.Button("Play 4"))
            {
                manager.TriggerSource(4);
            }
            if (GUILayout.Button("Play 5"))
            {
                manager.TriggerSource(5);
            }
            if (GUILayout.Button("Play 6"))
            {
                manager.TriggerSource(6);
            }
            if (GUILayout.Button("Play 7"))
            {
                manager.TriggerSource(7);
            }
            if (GUILayout.Button("Play 8"))
            {
                manager.TriggerSource(8);
            }
            EditorGUILayout.Space();

            DrawDefaultInspector();
        }
    }
}
