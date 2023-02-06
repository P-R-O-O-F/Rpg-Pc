using System;
using Students;
using UnityEngine;

namespace DefaultNamespace {
    public class Exit : MonoBehaviour {
        [SerializeField] private GameObject exitIndicator;
        
        private void OnTriggerEnter2D(Collider2D other) {
            Debug.Log("EnterFinish");
            if (other.gameObject.CompareTag("Player")) {
                Debug.Log("EnterFinish2");
                exitIndicator.SetActive(true);
                
                Player.Instance.State.ControlState = ControlState.None;
            }
        }
    }
}