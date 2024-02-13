using UnityEngine;

public class CameraMover : MonoBehaviour
{   
    [SerializeField] private Player _player;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _thrasholdDstance;

    private void Update()
    {
        if (_camera.transform.position.x - _player.transform.position.x <= _thrasholdDstance)
            _camera.transform.position = Vector3.MoveTowards(transform.position, _camera.transform.position + Vector3.right, _moveSpeed * Time.deltaTime);
    }
}
