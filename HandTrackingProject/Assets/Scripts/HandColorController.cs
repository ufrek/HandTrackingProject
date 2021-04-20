using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColorController : MonoBehaviour
{
    [SerializeField]
    GameObject leftHand;
    [SerializeField]
    GameObject rightHand;

    // Start is called before the first frame update
    public void RedHands()
    {
        leftHand.GetComponent<Renderer>().material.color = Color.red;
        rightHand.GetComponent<Renderer>().material.color = Color.red;
    }

    public void WhiteHands()
    {
        leftHand.GetComponent<Renderer>().material.color = Color.white;
        rightHand.GetComponent<Renderer>().material.color = Color.white;
    }

    public void BlueHands()
    {
        leftHand.GetComponent<Renderer>().material.color = Color.blue;
        rightHand.GetComponent<Renderer>().material.color = Color.blue;
    }
}
