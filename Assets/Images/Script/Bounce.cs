using UnityEngine;
using Students;

public class Bounce : MonoBehaviour {
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _body2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_body2D.velocity.y<0)
        {
            _animator.SetBool("Bounce", false);
            _animator.SetBool("Fall", true);
        }
        if (_body2D.velocity.y>0)
        {
            _animator.SetBool("Fall", false);
            _animator.SetBool("Bounce", true);
        }
    }
}
