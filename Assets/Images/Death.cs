using System;
using Students;
using UnityEngine;

namespace DefaultNamespace {
    public class Death : MonoBehaviour {
        [SerializeField] private Animator _animator;
        
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.gameObject.CompareTag("Player")) {
                _animator.SetBool("Death", true);
                Player.Instance.State.ControlState = ControlState.None;
                
            }
        }
        private void OnTriggerExit2D(Collider2D other) {
            if (other.gameObject.CompareTag("Player")) {
                _animator.SetBool("Death", false);
                Player.Instance.State.ControlState = ControlState.None;
            }
        }
    }
}