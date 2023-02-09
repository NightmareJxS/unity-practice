using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    string rank;
    [SerializeField]
    string suit;
    [SerializeField]
    bool faceUp;

    [SerializeField]
    Sprite spriteFaceUp;
    [SerializeField]
    Sprite spriteFaceDown;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetSprite();
    }

    void SetSprite()
    {
        if (faceUp)
        {
            spriteRenderer.sprite = spriteFaceUp;
        }
        else
        {
            spriteRenderer.sprite = spriteFaceDown;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
