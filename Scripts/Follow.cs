using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Target;
    private Vector3 offset;
    public float MaxY, MinY;
    [SerializeField] private AudioSource nhacnenSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        nhacnenSoundEffect.Play();
        offset = transform.position - Target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Target.position + offset;
        pos.y = Mathf.Clamp(pos.y, MinY, MaxY);
        transform.position = pos;
    }
}
 