using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private void Update()
    {
        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime, Space.World);
    }
}
