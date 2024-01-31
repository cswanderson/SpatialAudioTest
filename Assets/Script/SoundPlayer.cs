using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    [SerializeField] private AudioSource audioSource;

    public void PlayClip(float delay = 0.01f)
    {
        StartCoroutine(PlayWithDelay(delay));
    }

    private IEnumerator PlayWithDelay(float time)
    {
        yield return new WaitForSeconds(time);
        audioSource.PlayOneShot(clip);
    }
}
