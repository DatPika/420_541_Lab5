using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;
    private bool gotHit = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        if (gotHit)
        {
            GameManager.Instance.IncrementScore();
            gotHit = false;
        }
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();
        gotHit = true;
    }
}
