using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] bool stagger = false; 
    [SerializeField] private List<SoundPlayer> sources = new List<SoundPlayer>();

    public void TriggerAllSources()
    {
        float delayTimer = 0;
        foreach (SoundPlayer source in sources)
        {
            source.PlayClip(delayTimer);
            if(stagger) delayTimer+=0.5f;
        }
    }

    public void TriggerSource(int index)
    {
        sources[index-1].PlayClip();
    }
}
