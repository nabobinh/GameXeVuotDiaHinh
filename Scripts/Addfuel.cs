using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addfuel : MonoBehaviour
{
    public MotorController motorController;
    [SerializeField] private AudioSource refuelSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fuel"))
        {
            refuelSoundEffect.Play();
            motorController.fuel = 1;
            Destroy(collision.gameObject);
        }
    }
}
