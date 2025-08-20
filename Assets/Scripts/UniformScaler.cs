using UnityEngine;

public class UniformScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.5f;

    private void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += Vector3.one * scaleChange;
    }
}
