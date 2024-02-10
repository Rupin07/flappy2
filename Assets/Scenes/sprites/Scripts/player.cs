
using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite[] Sprites;
    
    private int spriteIndex;
    
    private Vector3 direction;
    
    public float gravity = -9.8f;
    
    public float strength = 5f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer > ();
        
    }

    private void Start()
    
    {
        InvokeRepeating()
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
            
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

    }
}private void AnimateSprite()
