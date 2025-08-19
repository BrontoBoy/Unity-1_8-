using UnityEngine;

public class YAxisRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
