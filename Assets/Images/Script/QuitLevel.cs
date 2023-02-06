using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitLevel : MonoBehaviour
{
    [SerializeField] private GameObject informationIndicator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            informationIndicator.SetActive(true);
        }
        if (Input.GetKey(KeyCode.F))
        {
            informationIndicator.SetActive(false);
        }
    }
}