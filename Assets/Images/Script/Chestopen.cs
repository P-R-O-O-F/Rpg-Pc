using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestopen : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _animator.SetBool("Opened", true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
