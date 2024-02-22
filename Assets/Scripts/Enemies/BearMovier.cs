using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BearMovier : MonoBehaviour
{
    [SerializeField] private float _walkSpeed;

    private Rigidbody2D _rigidbody;
    private float _moveDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        SetRandomDirection();
    }

    private void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {
        _rigidbody.velocity = new Vector2(_moveDirection * _walkSpeed, _rigidbody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out EnemyWaypoint enemyWaypoint))
        {
            _moveDirection = -_moveDirection;
            TryFlipCharacter();
        }
    }

    private void TryFlipCharacter()
    {
        float rotationAngle = 180f;
        float rotateValue = (_moveDirection > 0) ? 0 : rotationAngle;

        transform.rotation = Quaternion.Euler(0, rotateValue, 0);
    }

    private void SetRandomDirection()
    {
        float rightDirection = 1.0f;
        float leftDirection = -1.0f;
        int directionQuantity = 2;

        _moveDirection = Random.Range(0, directionQuantity) == 0 ? leftDirection : rightDirection;
        TryFlipCharacter();
    }
}