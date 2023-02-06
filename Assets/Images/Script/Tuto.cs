using UnityEngine;



public class Tuto : MonoBehaviour
{
    [SerializeField] private GameObject informationIndicator;
    private bool HasBeenVisited;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") && !HasBeenVisited)
        {
            HasBeenVisited = true;
            informationIndicator.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            informationIndicator.SetActive(false);
        }
    }
}
