using System;
using Students;
using UnityEngine;

namespace DefaultNamespace {
    public class Reset : MonoBehaviour {
        [SerializeField] private Transform player;
        [SerializeField] private Transform StartElement;
        private void OnTriggerEnter2D(Collider2D other) {
            if (other.gameObject.CompareTag("Player")) {
                SetPos();
            }
        }
        private void Awake()
        {
            
        }

        private void SetPos()
        {
            Vector3 positionEl = StartElement.position;
            player.position = new Vector3(positionEl.x, positionEl.y, player.position.z);
}
        
        private void OnTriggerExit2D(Collider2D other) {
            if (other.gameObject.CompareTag("Player")) {
                SetPos();
            }
        }
    }
}