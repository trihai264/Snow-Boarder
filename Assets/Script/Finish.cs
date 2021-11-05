using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float loadDelay = 3f;
    [SerializeField] ParticleSystem finish;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            finish.Play();
            Invoke("ReloadScene", loadDelay);
            GetComponent<AudioSource>().Play();
        }

       
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
