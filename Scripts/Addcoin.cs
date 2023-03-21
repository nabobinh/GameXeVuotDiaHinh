using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addcoin : MonoBehaviour
{
    public MotorController motorController;

    //Tiền vàng
    public Text numbercoinText;
    [SerializeField] private AudioSource coinSoundEffect;

    public void AddScore5()
    {
        motorController.playerScore += 5;
        numbercoinText.text = motorController.playerScore.ToString();
    }
    public void AddScore25()
    {
        motorController.playerScore += 25;
        numbercoinText.text = motorController.playerScore.ToString();
    }
    public void AddScore100()
    {
        motorController.playerScore += 100;
        numbercoinText.text = motorController.playerScore.ToString();
    }
    public void AddScore500()
    {
        motorController.playerScore += 500;
        numbercoinText.text = motorController.playerScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin5"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            AddScore5();
        }
        if (collision.gameObject.CompareTag("Coin25"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            AddScore25();
        }
        if (collision.gameObject.CompareTag("Coin100"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            AddScore100();
        }
        if (collision.gameObject.CompareTag("Coin500"))
        {
            coinSoundEffect.Play();
            Destroy(collision.gameObject);
            AddScore500();
        }
    }
}
