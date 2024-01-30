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
            if (GUILayout.Button("Play Front Left"))
            {
                manager.TriggerSource(1);
            }
            if (GUILayout.Button("Play Front Right"))
            {
                manager.TriggerSource(2);
            }
            if (GUILayout.Button("Play Center"))
            {
                manager.TriggerSource(3);
            }
            if (GUILayout.Button("Play Rear Left"))
            {
                manager.TriggerSource(4);
            }
            if (GUILayout.Button("Play Rear Right"))
            {
                manager.TriggerSource(5);
            }
            if (GUILayout.Button("Play Middle Left"))
            {
                manager.TriggerSource(6);
            }
            if (GUILayout.Button("Play Middle Right"))
            {
                manager.TriggerSource(7);
            }
            if (GUILayout.Button("Play Subwoofer"))
            {
                manager.TriggerSource(8);
            }
            EditorGUILayout.Space();

            DrawDefaultInspector();
        }
    }
}
