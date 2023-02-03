using UnityEngine;
using Students;

    public class Jump_controller : MonoBehaviour {
        [SerializeField] private Animator _animator;
        [SerializeField] private Rigidbody2D _body2D;
        [SerializeField] private float vSpeed;

        private void Start()
        {
            Player.Instance.State.IsGrounded = true;
            Player.Instance.State.IsJumping = false;
            _animator.SetBool("Stagger", false);
            _animator.SetBool("Death", false);
        }
        private void Update() {
            PlayerState state = Player.Instance.State;
            if (Input.GetKeyDown(KeyCode.Space) && state.ControlState == ControlState.Movable)
                Jump();
            if (Mathf.Approximately(_body2D.velocity.y, 0))
            {
                _animator.SetBool("Grounded", true);
                Player.Instance.State.IsGrounded = true;
                Player.Instance.State.IsJumping = false;
            }
            if(gameObject.CompareTag("WalkableSurfaceTag"))
            {
                Debug.Log(!gameObject.CompareTag("WalkableSurfaceTag"));
                _animator.SetBool("Stagger", false);
            }
        }

        private void Jump() {
            bool isGround = Player.Instance.State.IsGrounded;
            bool canJump = !Player.Instance.State.IsJumping;
            bool isNotStagger = !Player.Instance.State.IsStagger;

            if (isGround && canJump && isNotStagger) {
                _animator.Play("HeroKnight_Jump", -1, 0.0f);
            }

            if (Input.GetKeyDown(KeyCode.Space) && isGround && canJump && isNotStagger)
            {
                _body2D.AddForce(new Vector2(0, vSpeed), ForceMode2D.Impulse);
                _animator.SetBool("Grounded", false);
                Player.Instance.State.IsGrounded = false;
                
            }
            if (Input.GetKeyDown(KeyCode.Space) && !isGround && canJump && isNotStagger)
            {
                _animator.Play("HeroKnight_Jump", -1, 0.0f);
                _animator.SetBool("Jumping", true);
                _body2D.AddForce(new Vector2(0, vSpeed), ForceMode2D.Impulse);
                Player.Instance.State.IsJumping = true;
                _animator.SetBool("Jumping", false);
            }
            
            
            
        }
        private void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("WalkableSurfaceTag")) {
                _animator.SetBool("Stagger", true);
                _animator.Play("HeroKnight_LedgeGrab", -1, 0.0f);
            }
        }
        private void OnCollisionExit2D(Collision2D other) {
            if (!other.gameObject.CompareTag("WalkableSurfaceTag")) {
                _animator.SetBool("Stagger", false);
            }
        }
        }
    
