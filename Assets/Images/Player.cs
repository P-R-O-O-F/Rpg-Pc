using System;
using UnityEngine;

namespace Students {
    public class CollectState {
        private int _diamondCount;

        public int DiamondCount {
            get => _diamondCount;
            set {
                _diamondCount = value;
                OnDiamondCountUpdated?.Invoke(_diamondCount);
            }
        }

        public event Action<int> OnDiamondCountUpdated;
    }

    public class Player : MonoBehaviour {
        private PlayerState _state;
        private CollectState _collectState;
        private Animator _animator;

        public static Player Instance { get; private set; }
        public PlayerState State => _state;
        public CollectState CollectState => _collectState;

        private void Awake() {
            Instance = this;
            _collectState = new CollectState();
            _state = new PlayerState() {
                IsGrounded = true,
                IsJumping = false,
                IsStagger = false,
                ControlState = ControlState.Movable
            };

#if UNITY_EDITOR
            _collectState.OnDiamondCountUpdated += i => Debug.Log($"Diamond Count updated {i}");
#endif
        }
        
        
    }
}