using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuOui : MonoBehaviour, IPointerDownHandler
{
    void LoadMenu () {
        Debug.Log("Oui");
        SceneManager.LoadScene("Menu");
    }
    
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        LoadMenu();
    }
   
}
