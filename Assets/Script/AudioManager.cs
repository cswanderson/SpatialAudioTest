using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] bool stagger = false; 
    [SerializeField] private List<SoundPlayer> sources;

    public void TriggerAllSources()
    {
        int delayTimer = 0;
        foreach (SoundPlayer source in sources)
        {
            source.PlayClip(delayTimer);
            if(stagger) delayTimer++;
        }
    }

    public void TriggerSource(int index)
    {
        sources[index-1].PlayClip();
    }
}
