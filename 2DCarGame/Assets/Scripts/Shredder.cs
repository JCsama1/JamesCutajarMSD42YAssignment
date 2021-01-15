using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    [SerializeField] AudioClip PointGainSound;
    [SerializeField] [Range(0, 1)] float PointGainSoundVolume = 0.75f;

    [SerializeField] int scoreValue = 50;

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        AudioSource.PlayClipAtPoint(PointGainSound, Camera.main.transform.position, PointGainSoundVolume);

        Destroy(otherObject.gameObject);

        FindObjectOfType<GameSession>().AddToScore(scoreValue);
    }
}
