using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CanvasCinemachine : MonoBehaviour
{
    public GameObject kartCam;
    public GameObject guitarcam;

    public void ActivateGuitar()
    {
        kartCam.SetActive(false);
        guitarcam.SetActive(true);
    }

    public void ActivateKart()
    {
        kartCam.SetActive(true);
        guitarcam.SetActive(false);
    }
}
