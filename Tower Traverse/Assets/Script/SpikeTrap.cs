using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class SpikeTrap : MonoBehaviour, ITrap
{
    [Header("Sprites")]
    [SerializeField] private Sprite upSprite;
    [SerializeField] private Sprite downSprite;

    [Header("Trap Preferences")]
    [SerializeField] private float activateTime;
    [SerializeField] private float activeDuration;
    [SerializeField] private bool isOnTimer;

    private bool active;
    private float timer = 0;
    private BoxCollider2D collider;
    private SpriteRenderer spriteRend;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        spriteRend = GetComponent<SpriteRenderer>();

        collider.enabled = false;
    }

    void Update()
    {
        #region Triggerable Varient
        if (!isOnTimer) {
            if (!active) return;

            timer += Time.deltaTime;

            if (timer > activeDuration) {
                active = false;
                spriteRend.sprite = downSprite;
                collider.enabled = false;
                timer = 0;
            }
            
            return;
        }
        #endregion
        #region Timer Varient
        timer += Time.deltaTime;

        if (timer > activateTime && !active)
        {
            active = true;
            spriteRend.sprite = upSprite;
            collider.enabled = true;
        }
        
        if(timer > activateTime + activeDuration)
        {
            active = false;
            spriteRend.sprite = downSprite;
            collider.enabled = false;

            timer = 0;
        }
        #endregion
    }

    public void Activate()
    {
        active = true;
        spriteRend.sprite = upSprite;
        collider.enabled = true;
    }
}