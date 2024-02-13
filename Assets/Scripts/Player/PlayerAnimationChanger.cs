using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimationChanger : MonoBehaviour
{
    private const int _idleIndex = 0;
    private const int _runIndex = 1;
    private const int _jumpIndex = 2;

    [SerializeField] private Vector3 currentPosition;

    private int _moveIndex = Animator.StringToHash("MoveIndex");   
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Run()
    {
        _animator.SetInteger(_moveIndex, _runIndex);
    }

    public void Jump()
    {
        _animator.SetInteger(_moveIndex, _jumpIndex);
    }

    public void Idle()
    {
        _animator.SetInteger(_moveIndex, _idleIndex);
    }
}