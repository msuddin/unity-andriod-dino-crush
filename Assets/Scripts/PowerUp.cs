using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    private ParticleSystem particles;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Break());
        }
    }

    private IEnumerator Break()
    {
        particles.Play();
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(particles.main.startLifetime.constantMax);
        Destroy(this.gameObject);
    }
}
