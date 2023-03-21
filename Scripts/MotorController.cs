using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MotorController : MonoBehaviour
{
    //Xăng xe
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public UnityEngine.UI.Image image;
    //Điểm thưởng
    public double playerScore = 0;
    //Xe 
    public Rigidbody2D ForntWheel;
    public Rigidbody2D Backwheel;
    public Rigidbody2D Motor;
    public float speed = 50f;
    public float MotorTorque = -100f;
    float input;

    [SerializeField] private AudioSource soundxechaySoundEffect;

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        image.fillAmount = fuel;
       // soundxechaySoundEffect.Play();

    }
    private void FixedUpdate()
    {
 
        if (fuel > 0)
        {
            
            ForntWheel.AddTorque(-input * speed * Time.fixedDeltaTime);
            Backwheel.AddTorque(-input * speed * Time.fixedDeltaTime);
            Motor.AddTorque(-input * MotorTorque * Time.fixedDeltaTime);
         
        }
        fuel -= fuelconsumption * Mathf.Abs(input) * Time.fixedDeltaTime;
        
    }
  
}
