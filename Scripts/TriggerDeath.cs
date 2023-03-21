using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDeath : MonoBehaviour
{
    [SerializeField] private AudioSource crackSoundEffect;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ground")
        {
            StartCoroutine(LeverlRestart());
        }
        if (col.tag == "Ground2")
        {
            StartCoroutine(Lever2Restart());
        }
        if (col.tag == "Ground3")
        {
            StartCoroutine(Lever3Restart());
        }
        //
        if (col.tag == "Co")
        {
            StartCoroutine(Lever2Restart());
        }
        if (col.tag == "Co2")
        {
            StartCoroutine(Lever3Restart());
        }
    }

    IEnumerator LeverlRestart()
    {
        crackSoundEffect.Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Lever1");
    }
    IEnumerator Lever2Restart()
    {
        crackSoundEffect.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Lever2");
    }
    IEnumerator Lever3Restart()
    {
        crackSoundEffect.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Lever3");
    }
}
