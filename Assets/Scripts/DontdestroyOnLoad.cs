using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontdestroyOnLoad : MonoBehaviour {
 
 public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
            if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}

}
