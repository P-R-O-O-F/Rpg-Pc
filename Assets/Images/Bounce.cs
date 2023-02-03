using UnityEngine;
using Students;

namespace DefaultNamespace {
public class Bounce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _body2D;
    [SerializeField] private Animator _animator;

    private void Bouncing()
    {
        if (_body2D.velocity.y > 0)
        {
            _animator.Play("HeroKnight_Jump", -1, 0.0f);
            _animator.SetBool("Bounce", true);
        }
        if(_body2D.velocity.y < 0)
        {
            _animator.Play("HeroKnight_Fall", -1, 0.0f);
            _animator.SetBool("Bounce", false);
        }
    }
    
}
}