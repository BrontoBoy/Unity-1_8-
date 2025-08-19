using UnityEngine;

public class TransformController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 5f;

    [Header("Rotation Settings")]
    [SerializeField] private float _rotationSpeed = 90f;

    [Header("Scale Settings")]
    [SerializeField] private float _scaleSpeed = 0.5f;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
