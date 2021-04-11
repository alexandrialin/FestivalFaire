using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject animationCamera;
    public GameObject firstPersonCamera;
    void Start()
    {
        StartCoroutine(Switch());
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(11);
        animationCamera.SetActive(false);
        firstPersonCamera.SetActive(true);
    }
}
