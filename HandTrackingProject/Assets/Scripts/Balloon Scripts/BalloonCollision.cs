using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class BalloonCollision : MonoBehaviour
{
    [SerializeField]
    AudioClip sPop;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            this.GetComponent<AudioSource>().PlayOneShot(sPop);
            Destroy(this.gameObject);

        }

    }
}
