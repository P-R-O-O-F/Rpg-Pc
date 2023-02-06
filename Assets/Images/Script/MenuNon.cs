using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuNon : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject informationIndicator;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("Non");
        informationIndicator.SetActive(false);
    }
}
