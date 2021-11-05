using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crash;
    [SerializeField] AudioClip crashsound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControl();
            crash.Play();
            GetComponent<AudioSource>().PlayOneShot(crashsound);
            Invoke("Reload", loadDelay);
        }

        
    }
    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
