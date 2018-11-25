using System.Collections;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public AudioSource source;

    IEnumerator Start()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.loop = true;
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
    }

}
