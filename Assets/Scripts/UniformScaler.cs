using UnityEngine;

public class UniformScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.5f;

    void Update()
    {
        float scaleChange = _scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
