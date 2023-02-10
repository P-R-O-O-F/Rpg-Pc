using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Students;

namespace DefaultNamespace
{
    public class Checkpoint : MonoBehaviour
    {
        private bool triggered
        {
            get { return triggered; }
            set { triggered = value; }
        }

        void Start()
        {
            triggered = false;
        }
        private void SetPos()
        {
				
            Vector3 positionEl = CheckpointElement.position;
            player.position = new Vector3(positionEl.x, positionEl.y, player.position.z);
        }

        // Update is called once per frame
        void Update()
        {

        }

        [SerializeField] private Transform CheckpointElement;
        [SerializeField] private Transform player;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                SetPos();
            }
        }
        public bool GetTriggered()
        {
            return triggered;
        }
    }
}