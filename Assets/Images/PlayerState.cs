using System;


public enum ControlState {
    None,
    Movable
}

public class PlayerState {
    private bool _jumping;

    public ControlState ControlState { get; set; }
    public bool IsGrounded { get; set; }
    public bool IsStagger { get; set; }

    public bool IsJumping {
        get => _jumping;
        set {
            _jumping = value;
            if (_jumping)
                OnJumping?.Invoke();
        }
    }

    #region EVENTS
    public event Action OnJumping;

    #endregion
}