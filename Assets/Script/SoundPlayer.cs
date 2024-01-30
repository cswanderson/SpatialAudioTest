using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClip(float delay = 0)
    {
        StartCoroutine(PlayWithDelay(delay));
    }

    private IEnumerator PlayWithDelay(float time)
    {
        yield return new WaitForSeconds(time);
        audioSource.PlayOneShot(clip);
    }
}
