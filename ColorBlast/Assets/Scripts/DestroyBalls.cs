using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalls : MonoBehaviour {

    public SpriteRenderer sr;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ball(Clone)")
        {
            FindObjectOfType<AudioManager>().Play("ballDestroy");
            Destroy(other.gameObject);
        }
    }
}
